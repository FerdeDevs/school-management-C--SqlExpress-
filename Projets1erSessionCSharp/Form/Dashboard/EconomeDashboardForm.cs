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
using Projets1erSessionCSharp.user.userEdit;

namespace Projets1erSessionCSharp
{
    public partial class EconomeDashboardForm : Form
    {
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

        public EconomeDashboardForm()
        {
            InitializeComponent();
        }

        private void EconomeDashboardForm_Load(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int formVerification = 1;
            EconomeForm child = new EconomeForm(formVerification) { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            MainFormPanel.Controls.Add(child);
            child.Show();
            child.BringToFront();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "")
            {
                searchData();
            }
            string search = txtRechercher.Text.ToString();
            //code = txtRechercher.Text.ToString();
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM econome WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%'";

            SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            DataGridView.Rows.Clear();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Modifier", "Supprimer");
            }
            //6. Connection fermer
            connection.Close();
        }

        void searchData()
        {
            //code = txtRechercher.Text.ToString();
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM econome ORDER BY code DESC";
            //5. Executer la requete
            SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            DataGridView.Rows.Clear();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Modifier", "Supprimer");
            }
            //6. Connection fermer
            connection.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                int verification = 0;
                string IdEdit = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                EconomeEdit child = new EconomeEdit(IdEdit, verification) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
            if (e.ColumnIndex == 8 && e.RowIndex > -1)
            {
                DialogResult result = MessageBox.Show("Voulez vous supprimer " + DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), "Supprimer " + DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //2. Recuperer le code
                    string codeRecup = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    //3. Etablir la connection
                    SqlConnection connection = new SqlConnection(connectionString);

                    //4. Requete
                    string query = "DELETE FROM econome WHERE code = @code";

                    //5. Executer la requete
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", codeRecup);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        ShowToast("SUCCESS", "Supression réussie");
                        searchData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex);
                    }

                    searchData();
                }
            }
        }

    }
}
