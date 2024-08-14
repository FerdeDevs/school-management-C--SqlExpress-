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
    public partial class PayrollForm : Form
    {
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        string codeEco;
        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        public PayrollForm( string Ncode)
        {
            InitializeComponent();
            codeEco = Ncode;
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            searchData("admin");
            searchData("enseignant");
            searchData("secretaire");
            searchData("econome");
        }

        void searchData(string table)
        {
            //code = txtRechercher.Text.ToString();
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            if (table == "admin")
            {
                //4. Requete
                string query = "SELECT * FROM admin ORDER BY code DESC";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridViewAdmin.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewAdmin.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Payer");
                }
            }
            else if (table == "econome")
            {
                //4. Requete
                string query = "SELECT * FROM econome ORDER BY code DESC";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridViewEconome.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewEconome.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Payer");
                }
            }
            else if (table == "enseignant")
            {
                //4. Requete
                string query = "SELECT * FROM enseignant ORDER BY code DESC";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridViewEns.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewEns.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], reader["faculte"], reader["cours"], "Payer");
                }
            }
            else if (table == "secretaire")
            {
                //4. Requete
                string query = "SELECT * FROM secretaire ORDER BY code DESC";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridViewSecretaire.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewSecretaire.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Payer");
                }
            }
            else
            {
            }
            //6. Connection fermer
            connection.Close();
        }

        public void SearchButton(string text, string table)
        {
            string search = text.ToString();
            if (search == "")
            {

                if (table == "admin")
                {
                    searchData("admin");
                }
                else if (table == "econome")
                {
                    searchData("econome");
                }
                else if (table == "enseignant")
                {
                    searchData("enseignant");
                }
                else if (table == "secretaire")
                {
                    searchData("secretaire");
                }
                else { }
            }
            else
            {
                //2. Etablir la connection
                SqlConnection connection = new SqlConnection(connectionString);

                //3. Ouvrir la conection 
                connection.Open();
                if (table == "admin")
                {
                    //4. Requete
                    string query = "SELECT * FROM admin WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%'";

                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataGridViewAdmin.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewAdmin.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Modifier", "Supprimer");
                    }
                }
                else if (table == "econome")
                {
                    //4. Requete
                    string query = "SELECT * FROM econome WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%'";

                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataGridViewEconome.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewEconome.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Modifier", "Supprimer");
                    }
                }
                else if (table == "enseignant")
                {
                    //4. Requete
                    string query = "SELECT * FROM enseignant WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%'";

                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataGridViewEns.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewEns.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], reader["faculte"], reader["cours"], "Payer");
                    }
                }
                else if (table == "secretaire")
                {
                    //4. Requete
                    string query = "SELECT * FROM secretaire WHERE code like '%" + search + "%' OR email like '%" + search + "%' OR nom like '%" + search + "%'";

                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = command.ExecuteReader();

                    DataGridViewSecretaire.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewSecretaire.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["adresse"], reader["telephone"], "Payer");
                    }
                }
                else
                {
                }
                //6. Connection fermer
                //connection.Close();
            }
        }

        private void txtRechercherSecretaire_Enter(object sender, EventArgs e)
        {
            if (txtRechercherSecretaire.Text == "Rechercher par Matricule ou Email")
            {
                txtRechercherSecretaire.Text = "";
                txtRechercherSecretaire.ForeColor = Color.Black;
            }
        }

        private void txtRechercherSecretaire_Leave(object sender, EventArgs e)
        {
            if (txtRechercherSecretaire.Text == "")
            {
                txtRechercherSecretaire.Text = "Rechercher par Matricule ou Email";
                txtRechercherSecretaire.ForeColor = Color.Silver;
            }
        }

        private void txtRechercherEns_Enter(object sender, EventArgs e)
        {
            if (txtRechercherEns.Text == "Rechercher par Matricule ou Email")
            {
                txtRechercherEns.Text = "";
                txtRechercherEns.ForeColor = Color.Black;
            }
        }

        private void txtRechercherEns_Leave(object sender, EventArgs e)
        {
            if (txtRechercherEns.Text == "")
            {
                txtRechercherEns.Text = "Rechercher par Matricule ou Email";
                txtRechercherEns.ForeColor = Color.Silver;
            }
        }

        private void txtRechercherEconome_Enter(object sender, EventArgs e)
        {
            if (txtRechercherEconome.Text == "Rechercher par Matricule ou Email")
            {
                txtRechercherEconome.Text = "";
                txtRechercherEconome.ForeColor = Color.Black;
            }
        }

        private void txtRechercherEconome_Leave(object sender, EventArgs e)
        {
            if (txtRechercherEconome.Text == "")
            {
                txtRechercherEconome.Text = "Rechercher par Matricule ou Email";
                txtRechercherEconome.ForeColor = Color.Silver;
            }
        }

        private void txtRechercherAdmin_Enter(object sender, EventArgs e)
        {
            if (txtRechercherAdmin.Text == "Rechercher par Matricule ou Email")
            {
                txtRechercherAdmin.Text = "";
                txtRechercherAdmin.ForeColor = Color.Black;
            }
        }

        private void txtRechercherAdmin_Leave(object sender, EventArgs e)
        {
            if (txtRechercherAdmin.Text == "")
            {
                txtRechercherAdmin.Text = "Rechercher par Matricule ou Email";
                txtRechercherAdmin.ForeColor = Color.Silver;
            }
        }

        private void btnRechercherAdmin_Click(object sender, EventArgs e)
        {
            SearchButton(txtRechercherAdmin.Text, "admin");
        }
        private void btnRechercherEns_Click(object sender, EventArgs e)
        {
            SearchButton(txtRechercherEns.Text, "enseignant");
        }
        private void btnRechercherEconome_Click(object sender, EventArgs e)
        {
            SearchButton(txtRechercherEconome.Text, "econome");
        }
        private void btnRechercherSecretaire_Click(object sender, EventArgs e)
        {
            SearchButton(txtRechercherSecretaire.Text, "secretaire");
        }

        private void btnRefreshAdmin_Click(object sender, EventArgs e)
        {
            searchData("admin");
        }

        private void btnRefreshEns_Click(object sender, EventArgs e)
        {
            searchData("enseignant");
        }

        private void btnRefreshEconome_Click(object sender, EventArgs e)
        {
            searchData("econome");
        }

        private void btnRefreshSecretaire_Click(object sender, EventArgs e)
        {
            searchData("secretaire");
        }

        private void DataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string table = "admin";
                string IdEdit = DataGridViewAdmin.Rows[e.RowIndex].Cells[0].Value.ToString();
                SinglePayrollForm child = new SinglePayrollForm(IdEdit, table, codeEco) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
        }

        private void DataGridViewEns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.RowIndex > -1)
            {
                string table = "enseignant";
                string IdEdit = DataGridViewEns.Rows[e.RowIndex].Cells[0].Value.ToString();
                SinglePayrollForm child = new SinglePayrollForm(IdEdit, table, codeEco) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
        }

        private void DataGridViewEconome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string table = "econome";
                string IdEdit = DataGridViewEconome.Rows[e.RowIndex].Cells[0].Value.ToString();
                SinglePayrollForm child = new SinglePayrollForm(IdEdit, table, codeEco) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
        }

        private void DataGridViewSecretaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string table = "secretaire";
                string IdEdit = DataGridViewSecretaire.Rows[e.RowIndex].Cells[0].Value.ToString();
                SinglePayrollForm child = new SinglePayrollForm(IdEdit, table, codeEco) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                DataGridViewPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();

            }
        }
    }
}
