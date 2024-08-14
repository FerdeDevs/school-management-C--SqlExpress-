using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Projets1erSessionCSharp
{
    public partial class ApproveForm : Form
    {
     
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        public ApproveForm()
        {
            InitializeComponent();
        }

   

        public void searchData()
        {
            string valeurSelectionnee = txtTableSwitch.Text;

            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            if (valeurSelectionnee == "secretaire")
            {
                string query = "SELECT * FROM secretaire WHERE status = 0";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Approuver");
                }
            }
            else if (valeurSelectionnee == "enseignant")
            {
                string query = "SELECT * FROM enseignant WHERE status = 0";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Approuver");
                }
            }
            else if (valeurSelectionnee == "econome")
            {
                string query = "SELECT * FROM econome WHERE status = 0";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Approuver");
                }
            }
            else
            {
                string query = "SELECT * FROM admin WHERE status = 0";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Approuver");
                }
            }
        
            //6. Connection fermer
            connection.Close();
           
        }

        private void ApproveForm_Load(object sender, EventArgs e)
        {
            searchData();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string valeurSelectionnee = txtTableSwitch.Text;
                       if (valeurSelectionnee == "secretaire"){
                           //2. Recuperer le code
                           string codeRecup = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                           //3. Etablir la connection
                           SqlConnection connection = new SqlConnection(connectionString);

                           //4. Requete
                           string query = "UPDATE secretaire set status = @status WHERE code = @code";

                           //5. Executer la requete
                           SqlCommand command = new SqlCommand(query, connection);
                           command.Parameters.AddWithValue("@status", 1);
                           command.Parameters.AddWithValue("@code", codeRecup);

                           try
                           {
                               connection.Open();
                               int rowsAffected = command.ExecuteNonQuery();
                               ShowToast("SUCCESS", "Approbation réussie");
                               searchData();
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show("Erreur : " + ex);
                           }
                       }
                       else if (valeurSelectionnee == "enseignant"){
                           //2. Recuperer le code
                           string codeRecup = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                           //3. Etablir la connection
                           SqlConnection connection = new SqlConnection(connectionString);

                           //4. Requete
                           string query = "UPDATE enseignant set status = @status WHERE code = @code";

                           //5. Executer la requete
                           SqlCommand command = new SqlCommand(query, connection);
                           command.Parameters.AddWithValue("@status", 1);
                           command.Parameters.AddWithValue("@code", codeRecup);

                           try
                           {
                               connection.Open();
                               int rowsAffected = command.ExecuteNonQuery();
                               ShowToast("SUCCESS", "Approbation réussie");
                               searchData();
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show("Erreur : " + ex);
                           }
                       }
                       else if (valeurSelectionnee == "econome") {
                           //2. Recuperer le code
                           string codeRecup = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                           //3. Etablir la connection
                           SqlConnection connection = new SqlConnection(connectionString);

                           //4. Requete
                           string query = "UPDATE econome set status = @status WHERE code = @code";

                           //5. Executer la requete
                           SqlCommand command = new SqlCommand(query, connection);
                           command.Parameters.AddWithValue("@status", 1);
                           command.Parameters.AddWithValue("@code", codeRecup);

                           try
                           {
                               connection.Open();
                               int rowsAffected = command.ExecuteNonQuery();
                               ShowToast("SUCCESS", "Approbation réussie");
                               searchData();
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show("Erreur : " + ex);
                           }
                       }
                       else {
                           //2. Recuperer le code
                           string codeRecup = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                           //3. Etablir la connection
                           SqlConnection connection = new SqlConnection(connectionString);

                           //4. Requete
                           string query = "UPDATE admin set status = @status WHERE code = @code";

                           //5. Executer la requete
                           SqlCommand command = new SqlCommand(query, connection);
                           command.Parameters.AddWithValue("@status", 1);
                           command.Parameters.AddWithValue("@code", codeRecup);

                           try
                           {
                               connection.Open();
                               int rowsAffected = command.ExecuteNonQuery();
                               ShowToast("SUCCESS", "Approbation réussie");
                               searchData();
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show("Erreur : " + ex);
                           }
                       }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
        }
  
    }
}
