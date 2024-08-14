using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Projets1erSessionCSharp
{
    class addUser
    {
    }

    public class UserManager
    {
        private SqlConnection connection;
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public UserManager()
        {
            connection = new SqlConnection(connectionString);
        }

        public DataTable GetAllProducts()
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT ProductID, ProductName, ProductDescription, ProductImage FROM Products";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving products: " + ex.Message);
            }

            return table;
        }
    }
}
