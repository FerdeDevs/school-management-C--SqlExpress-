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
    public partial class SecretaireForm : Form
    {

        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
       
        string nom, prenom, email, sexe, telephone, adresse, mdp, rmdp;

        int formVerification;

        public void Clear()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtEmail.Text = "";
            txtSexe.SelectedIndex = 0;
            txtTel.Text = "";
            txtAdresse.Text = "";
            txtMdp.Text = "";
            txtRepeteMdp.Text = "";
        }

        //Matricule
        static Random random = new Random();

        static string GenererMatricule(string nom, string prenom)
        {
            string matricule = "";

            // Prendre la première lettre du nom
            matricule += nom.Substring(0, Math.Min(nom.Length, 1)).ToUpper();

            // Prendre la première lettre du prénom
            matricule += prenom.Substring(0, Math.Min(prenom.Length, 1)).ToUpper();

            // Générer quatre chiffres aléatoires
            matricule += random.Next(1000, 10000);

            return matricule;
        }

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);

            toast.Show();
        }

        public SecretaireForm(int Nver)
        {
            InitializeComponent();
            formVerification = Nver;
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
            }
        }

        private void chkMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMdp.Checked)
            {
                txtMdp.PasswordChar = (char)0;
                txtRepeteMdp.PasswordChar = (char)0;
            }
            else
            {
                txtMdp.PasswordChar = Convert.ToChar("*");
                txtRepeteMdp.PasswordChar = Convert.ToChar("*");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Declaration des variables saisies
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            email = txtEmail.Text;
            sexe = txtSexe.Text;
            telephone = txtTel.Text;
            adresse = txtAdresse.Text;
            mdp = txtMdp.Text;
            rmdp = txtRepeteMdp.Text;
            int status = 0;
            string matricule = GenererMatricule(nom, prenom);

            //verificarions des variables s'il ne sont pas vides
            if (nom == "") { ShowToast("INFO", "Veuillez remplir le champ nom"); txtNom.Focus(); }
            else if (prenom == "") { ShowToast("INFO", "Veuillez remplir le champ prénom"); txtPrenom.Focus(); }
            else if (email == "") { ShowToast("INFO", "Veuillez remplir le champ email"); txtEmail.Focus(); }
            else if (sexe == "" || sexe == "Choisir") { ShowToast("INFO", "Veuillez choisir un option dans le champ sexe"); txtSexe.Focus(); }
            else if (telephone == "") { ShowToast("INFO", "Veuillez remplir le champ téléphone"); txtTel.Focus(); }
            else if (adresse == "") { ShowToast("INFO", "Veuillez remplir le champ adresse"); txtAdresse.Focus(); }
            else if (mdp == "" || rmdp == "") { ShowToast("INFO", "Veuillez remplir le champ mot de passe"); txtMdp.Focus(); }
            else if (browseBtn.Text == "") { ShowToast("ERROR", "Photo profile ne doit pas être vide"); }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    byte[] images = null;
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);

                    string query = "INSERT INTO secretaire (code,nom,prenom,email,adresse,sexe,telephone,mdp,photos,status) VALUES (@code,@nom,@prenom,@email,@adresse,@sexe,@telephone,@mdp,@photos,@status)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parameters
                    command.Parameters.AddWithValue("@code", matricule);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@adresse", adresse);
                    command.Parameters.AddWithValue("@telephone", telephone);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@mdp", mdp);
                    command.Parameters.AddWithValue("@photos", images);
                    command.Parameters.AddWithValue("@status", status);
                    //Path.GetFileName(picProfile.ImageLocation)
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            ShowToast("SUCCESS", "Insertion réussie");
                            Clear();
                            if (formVerification == 1)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            ShowToast("ERROR", "Insertion échouée");
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SecretaireForm_Load(object sender, EventArgs e)
        {
            txtSexe.SelectedIndex = 0;
            if (formVerification == 1)
            {
                btnBack.Show();
            }
            else
            {
                btnBack.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
