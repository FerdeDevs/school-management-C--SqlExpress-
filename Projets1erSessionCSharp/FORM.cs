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
    public partial class FORM : Form
    {
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        string code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, role;
        byte[] imageBytes;

        public FORM(string Ncode, string Nnom, string Nprenom, string Nemail, string Nsexe, string Nadresse, string Ncours, string Nfaculte, string Ntelephone, byte[] NimageBytes, string Nrole)
        {
            InitializeComponent();
            code = Ncode;
            nom = Nnom;
            prenom = Nprenom;
            email = Nemail;
            sexe = Nsexe;
            adresse = Nadresse;
            cours = Ncours;
            faculte = Nfaculte;
            telephone = Nadresse;
            imageBytes = NimageBytes;
            role = Nrole;
        }

        private void FORM_Load(object sender, EventArgs e)
        {
            lblNom.Text = nom;
            lblPrenom.Text = prenom;
            lblRole.Text = role;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                picBox.Image = Image.FromStream(ms);
            }
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM payroll WHERE codeEmp = '" + code + "' AND employer = '" + role + "'";


            //5. Executer la requete
            SqlDataAdapter adap = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adap.Fill(data);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {

                    lblAmount.Text = row["montant"].ToString();
                }
            }
        
        }
    }
}
