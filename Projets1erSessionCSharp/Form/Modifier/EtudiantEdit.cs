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
    public partial class EtudiantEdit : Form
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

        public EtudiantEdit(string NewId, int Nver)
        {
            InitializeComponent();
            ID = NewId;
            verification = Nver;
        }

        private void EtudiantEdit_Load(object sender, EventArgs e)
        {
             searchData();
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
                string query = "SELECT * FROM etudiant WHERE code = '" + ID + "' ORDER BY code DESC";

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
                    txtFaculter.Text = reader["faculte"].ToString();
                    txtAdresse.Text = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfile.Image = Image.FromStream(ms);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "UPDATE etudiant set nom = @nom, prenom = @prenom, email = @email, adresse =@adresse, telephone = @telephone,faculte = @faculte, sexe = @sexe WHERE code = @code";

            //5. Executer la requete
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nom", txtNom.Text);
            command.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@adresse", txtAdresse.Text);
            command.Parameters.AddWithValue("@telephone", txtTel.Text);
            command.Parameters.AddWithValue("@faculte", txtFaculter.Text);
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

            string query = "UPDATE etudiant set photos = @photos WHERE code = @code";

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
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new Bitmap(openFileDialog.FileName);
                browseBtn.Text = openFileDialog.FileName;
                imgLocation = openFileDialog.FileName.ToString();
                picProfile.ImageLocation = imgLocation;
                pictureUpdated();

            }
        }
 


    }
}
