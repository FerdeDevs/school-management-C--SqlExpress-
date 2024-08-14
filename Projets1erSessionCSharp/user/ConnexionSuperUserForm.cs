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
    public partial class ConnexionSuperUserForm : Form
    {
       // string code, nom, prenom, email, telephone, sexe, adresse, photos, mdp;

        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

      
        private void Clear()
        {
            txtEmail.Text = "";
            txtMdp.Text = "";
        }
        public ConnexionSuperUserForm()
        {
            InitializeComponent();
        }
        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            register form = new register();
            form.Show();
            this.Hide();
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
               
                ShowToast("INFO", "Email Vide");
                txtEmail.Focus();
            }
            else if (txtMdp.Text == "")
            {
                ShowToast("INFO", "Mot de passe Vide");
                txtMdp.Focus();
            }
            else
            {
                string email = txtEmail.Text;
                string mdp = txtMdp.Text;
                //2. Etablir la connection
                SqlConnection connection = new SqlConnection(connectionString);

                //3. Ouvrir la conection 
                connection.Open();

                //4. Requete
                string query = "SELECT * FROM admin WHERE email = '" + email + "' AND mdp = '" + mdp + "' AND status = 1";

                //5. Executer la requete
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader rd = cmd.ExecuteReader();
              
                try
                {
                    if (rd.Read())
                    {
                        ShowToast("SUCCESS", "Connexion réussie");
                        register reg = new register();
                        reg.Show();
                        this.Hide();
                    }
                    else
                    {
                        ShowToast("ERROR", "Email ou Mot de passe invalide");
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
         
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}


                    //int rowsAffected = command.ExecuteNonQuery();
                    //if (rowsAffected > 0)
                    //{
                    //    ShowToast("SUCCESS", "Connexion réussie");
                    //    register reg = new register();
                    //    reg.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    ShowToast("ERROR", "Email ou Mot de passe invalide");
                    //}