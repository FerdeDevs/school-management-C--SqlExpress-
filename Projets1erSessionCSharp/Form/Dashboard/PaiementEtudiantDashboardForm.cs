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

namespace Projets1erSessionCSharp
{
    public partial class PaiementEtudiantDashboardForm : Form
    {
        string codeSec, nomSec, prenomSec, emailSec;
        public PaiementEtudiantDashboardForm(string Ncode,string Nnom,string Nprenom,string Nemail)
        {
            InitializeComponent();
            codeSec = Ncode;
            nomSec = Nnom;
            prenomSec = Nprenom;
            emailSec = Nemail;
        }

        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher par Matricule ou Email")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = Color.Black;
            }
        }

        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "")
            {
                txtRechercher.Text = "Rechercher par Matricule ou Email";
                txtRechercher.ForeColor = Color.Silver;
            }
        }

        void searchData()
        {
            //code = txtRechercher.Text.ToString();
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM etudiant WHERE status = 1";
            //5. Executer la requete
            SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            DataGridView.Rows.Clear();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["faculte"], reader["telephone"], "paiement");
            }
            //6. Connection fermer
            connection.Close();
        }

        private void PaiementEtudiantDashboardForm_Load(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string search = txtRechercher.Text.ToString();
            //code = txtRechercher.Text.ToString();
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM etudiant WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%' AND status = 1";

            SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            DataGridView.Rows.Clear();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["faculte"], reader["telephone"], "paiement");
            }
            //6. Connection fermer
            connection.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string nom = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string prenom = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string faculte = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                string IdEdit = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                PaiementEtudiant child = new PaiementEtudiant(IdEdit,nom,prenom,faculte,codeSec,nomSec,prenomSec,emailSec) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
        }
    }
}
