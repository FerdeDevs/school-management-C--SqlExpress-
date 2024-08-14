using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Projets1erSessionCSharp
{
    public partial class login : Form
    {
        string code, nom, prenom, email, telephone, sexe,cours,faculte, adresse, photos, mdp;

        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        private void Clear()
        {
            txtEmail.Text = "";
            txtMdp.Text = "";
        }

        public login()
        {
            InitializeComponent();
        }
        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void chkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMdp.Checked)
            {
                txtMdp.PasswordChar = (char)0;
            }
            else
            {
                txtMdp.PasswordChar = Convert.ToChar("*");
            }
        }

        private void btnCreerUnCompte_Click(object sender, EventArgs e)
        {
            ConnexionSuperUserForm user = new ConnexionSuperUserForm();
            user.Show();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                ShowToast("INFO", "Veuillez saisir l'email");
                txtEmail.Focus();
            }
            else if (txtMdp.Text == "")
            {
                ShowToast("INFO", "Veuillez saisir le mot de passe");
                txtMdp.Focus();
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {


                        string email = txtEmail.Text;
                        string mdp = txtMdp.Text;

                        // Check if user exists in admin table
                        string queryAdmin = "SELECT * FROM admin WHERE email = '" + email + "' AND mdp = '" + mdp + "' AND status = 1";
                        SqlDataAdapter sda = new SqlDataAdapter(queryAdmin, connection);
                        DataTable dataAdmin = new DataTable();
                        sda.Fill(dataAdmin);


                        // Check if user exists in enseignant table
                        string queryEns = "SELECT * FROM enseignant WHERE email = '" + email + "' AND mdp = '" + mdp + "' AND status = 1";
                        SqlDataAdapter sde = new SqlDataAdapter(queryEns, connection);
                        DataTable dataEnseignant = new DataTable();
                        sde.Fill(dataEnseignant);


                        // Check if user exists in secretaire table
                        string querySec = "SELECT * FROM secretaire WHERE email = '" + email + "' AND mdp = '" + mdp + "' AND status = 1";
                        SqlDataAdapter sds = new SqlDataAdapter(querySec, connection);
                        DataTable dataSecretaire = new DataTable();
                        sds.Fill(dataSecretaire);


                        // Check if user exists in econome table
                        string queryEco = "SELECT * FROM econome WHERE email = '" + email + "' AND mdp = '" + mdp + "' AND status = 1";
                        SqlDataAdapter sdm = new SqlDataAdapter(queryEco, connection);
                        DataTable dataEconome = new DataTable();
                        sdm.Fill(dataEconome);


                        if (dataAdmin.Rows.Count > 0)
                        {
                            ShowUserInfo(connection, queryAdmin, "Admin");
                        }
                        else if (dataEnseignant.Rows.Count > 0)
                        {
                            ShowUserInfo(connection, queryEns, "Enseignant");
                        }
                        else if (dataSecretaire.Rows.Count > 0)
                        {
                            ShowUserInfo(connection, querySec, "Secretaire");
                        }
                        else if (dataEconome.Rows.Count > 0)
                        {
                            ShowUserInfo(connection, queryEco, "Econome");
                        }
                        else
                        {
                            ShowToast("INFO", "Identifiant invalid");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void ShowUserInfo(SqlConnection connection, string query, string role)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                ShowToast("SUCCESS", "Bienvenue " + rd["nom"].ToString() + " " + rd["prenom"].ToString());

                if (role == "Enseignant")
                {
                    code = rd["code"].ToString();
                    nom = rd["nom"].ToString();
                    prenom = rd["prenom"].ToString();
                    email = rd["email"].ToString();
                    sexe = rd["sexe"].ToString();
                    adresse = rd["adresse"].ToString();
                    cours = rd["cours"].ToString();
                    faculte = rd["faculte"].ToString();
                    telephone = rd["telephone"].ToString();
                    byte[] imageBytes = (byte[])rd["photos"];
                    role = "enseignant";
                    MenuForm form = new MenuForm(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role);
                    form.Show();
                    this.Hide();
                }
                else if (role == "Secretaire")
                {
                    code = rd["code"].ToString();
                    nom = rd["nom"].ToString();
                    prenom = rd["prenom"].ToString();
                    email = rd["email"].ToString();
                    sexe = rd["sexe"].ToString();
                    cours = "";
                    faculte = "";
                    adresse = rd["adresse"].ToString();
                    telephone = rd["telephone"].ToString();
                    byte[] imageBytes = (byte[])rd["photos"];
                    role = "secretaire";
                    MenuForm form = new MenuForm(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role);
                    form.Show();
                    this.Hide();
                }
                else if (role == "Econome")
                {
                    code = rd["code"].ToString();
                    nom = rd["nom"].ToString();
                    prenom = rd["prenom"].ToString();
                    email = rd["email"].ToString();
                    sexe = rd["sexe"].ToString();
                    cours = "";
                    faculte = "";
                    adresse = rd["adresse"].ToString();
                    telephone = rd["telephone"].ToString();
                    byte[] imageBytes = (byte[])rd["photos"];
                    role = "econome";
                    MenuForm form = new MenuForm(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role);
                    form.Show();
                    this.Hide();
                }
                else if (role == "Admin")
                {
                    code = rd["code"].ToString();
                    nom = rd["nom"].ToString();
                    prenom = rd["prenom"].ToString();
                    email = rd["email"].ToString();
                    sexe = rd["sexe"].ToString();
                    cours = "";
                    faculte = "";
                    adresse = rd["adresse"].ToString();
                    telephone = rd["telephone"].ToString();
                    byte[] imageBytes = (byte[])rd["photos"];
                    role = "admin";
                    MenuForm form = new MenuForm(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    ShowToast("ERROR", "Vous n'avez pas encore de compte");
                }
            }
            else
            {
                ShowToast("INFO", "Vous n'êtes pas encore inscrit");
            }

        }

        private void btnCreerUnCompte_Click_1(object sender, EventArgs e)
        {
            ConnexionSuperUserForm reg = new ConnexionSuperUserForm();
            reg.Show();
            this.Hide();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "email@example.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "email@example.com";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtMdp_Enter(object sender, EventArgs e)
        {
            if (txtMdp.Text == "mot de passe")
            {
                txtMdp.Text = "";
                txtMdp.ForeColor = Color.Black;
            }
        }

        private void txtMdp_Leave(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                txtMdp.Text = "mot de passe";
                txtMdp.ForeColor = Color.Gray;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voules vous quittez l'application definivement", "Quitter l'Application ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }


    }
}

