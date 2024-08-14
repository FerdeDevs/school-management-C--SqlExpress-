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

namespace Projets1erSessionCSharp.user.userEdit
{
    public partial class EconomeEdit : Form
    {
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        string ID;
        int verification;
        
        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        public void searchData()
        {
            try
            {
                //2. Etablir la connection
                SqlConnection connection = new SqlConnection(connectionString);

                //3. Ouvrir la conection 
                connection.Open();

                //4. Requete
                string query = "SELECT * FROM econome WHERE code = '" + ID + "' ORDER BY code DESC";

                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtNom.Text = reader["nom"].ToString();
                    txtPrenom.Text = reader["prenom"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtTel.Text = reader["telephone"].ToString();
                    txtSexe.Text = reader["sexe"].ToString();
                    txtAdresse.Text = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfileUpdate.Image = Image.FromStream(ms);
                    }
                }
                reader.Close();
                //6. Connection fermer
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
                
           
           
        }

        public EconomeEdit(string NewId, int Nver)
        {
            InitializeComponent();
            ID = NewId;
            verification = Nver;
        }

        private void EconomeEdit_Load(object sender, EventArgs e)
        {
               panelMdp.Hide();
            if (verification == 1)
            {
                btnClear.Hide();
                lblMdpUpdate.Show();
                picturePanel.Show();
                btnBack.Hide();
            }
            else {
                btnBack.Show();
                lblMdpUpdate.Hide();
                picturePanel.Hide();
            }
            searchData();
        }

        public void disabled(bool boolVar)
        {
            txtNom.Enabled = boolVar;
            txtPrenom.Enabled = boolVar;
            txtEmail.Enabled = boolVar;
            txtTel.Enabled = boolVar;
            txtSexe.Enabled = boolVar;
            txtAdresse.Enabled = boolVar;
            picturePanel.Enabled = boolVar;
            btnCreate.Enabled = boolVar;
            btnClear.Enabled = boolVar;
            lblMdpUpdate.Enabled = boolVar;
            btnBack.Enabled = boolVar;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "UPDATE econome set nom = @nom, prenom = @prenom, email = @email, adresse =@adresse, telephone = @telephone, sexe = @sexe WHERE code = @code";

            //5. Executer la requete
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nom", txtNom.Text);
            command.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@adresse", txtAdresse.Text);
            command.Parameters.AddWithValue("@telephone", txtTel.Text);
            command.Parameters.AddWithValue("@sexe", txtSexe.Text);
            command.Parameters.AddWithValue("@code", ID);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ShowToast("SUCCESS", "Modification réussie");
                    if (verification == 0)
                    {
                        this.Close();
                    }

                }
                else
                {
                    ShowToast("ERROR", "Modification échouée");
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

        private void lblMdpUpdate_Click(object sender, EventArgs e)
        {
            panelMdp.Show();
            disabled(false);
        }

        private void btnPanelMdp_Click(object sender, EventArgs e)
        {
            panelMdp.Hide();
            disabled(true);
        }

        private void btnMdpUpdate_Click(object sender, EventArgs e)
        {
            string mdp = txtMdpUpdate.Text;
            string rmdp = txtRepeteMdpUpdate.Text;
            if (mdp == rmdp)
            {
                if (mdp == "" || rmdp == "")
                {
                    ShowToast("INFO", "Veuillez remplir le champ mot de passe");
                    txtMdpUpdate.Focus();
                    txtRepeteMdpUpdate.Focus();
                }
                else
                {
                    //2. Etablir la connection
                    SqlConnection connection = new SqlConnection(connectionString);

                    //3. Ouvrir la conection 
                    connection.Open();

                    //4. Requete
                    string query = "UPDATE econome set mdp = @mdp WHERE code = @code";

                    //5. Executer la requete
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mdp", rmdp);
                    command.Parameters.AddWithValue("@code", ID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            ShowToast("SUCCESS", "Modification mot de passe réussie");
                        }
                        else
                        {
                            ShowToast("ERROR", "Modification mot de passe échouée");
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
            else
            {
                ShowToast("ERROR", "Mot de passe incohérent");
            }
        }

        public void pictureUpdated()
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            string query = "UPDATE econome set photos = @photos WHERE code = @code";

            //5. Executer la requete
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@photos", images);
            command.Parameters.AddWithValue("@code", ID);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ShowToast("SUCCESS", "Modification réussie");
                }
                else
                {
                    ShowToast("ERROR", "Modification échouée");
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

        string imgLocation = "";

        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProfileUpdate.Image = new Bitmap(openFileDialog.FileName);
                btnEditPicture.Text = openFileDialog.FileName;
                imgLocation = openFileDialog.FileName.ToString();
                picProfileUpdate.ImageLocation = imgLocation;
                pictureUpdated();

            }
        }

        private void chkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMdp.Checked)
            {
                txtMdpUpdate.PasswordChar = (char)0;
                txtRepeteMdpUpdate.PasswordChar = (char)0;
            }
            else
            {
                txtMdpUpdate.PasswordChar = Convert.ToChar("*");
                txtRepeteMdpUpdate.PasswordChar = Convert.ToChar("*");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
