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
    public partial class EnseignantForm : Form
    {
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
       
        string nom, prenom, email, sexe, telephone, adresse,faculte,cours, mdp, rmdp;

        int formVerification;
        // Liste des faculte et cours
        Dictionary<string, List<string>> Faculte = new Dictionary<string, List<string>>
        {
            { "Choisir", new List<string> { "Choisir un faculter d'abord" } },
            { "Genie Civil", new List<string> { "Dessin Technique", "Cartographie", "Math Logique", "Algebre lineaire" } },
            { "Informatique", new List<string> { "React", "Python", "Kotlin", "Swift" } },
            { "Communication", new List<string> { "Art Oratoire", "Micro trottroire", "Grammaire", "Protocole" } },
            { "Administration", new List<string> { "Droit Adminisatrative", "Statistique", "Comptabilite", "informatique de bureau" } },
            { "Bio-Medicale", new List<string> { "Biologie", "Micro-biologie", "Analyse", "Synthese" } },
            { "Infirmiere", new List<string> { "Anatomie", "Nursing", "Pediatrie", "Orthopedie" } },
          
        };

        public void Clear()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtEmail.Text = "";
            txtSexe.SelectedIndex = 0;
            txtFaculte.SelectedIndex = 0;
            txtCours.SelectedIndex = 0;
            txtTel.Text = "";
            txtCours.SelectedIndex = 0;
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

        public EnseignantForm(int Nver)
        {
            InitializeComponent();
            txtFaculte.Items.AddRange(Faculte.Keys.ToArray());
            formVerification = Nver;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Declaration des variables saisies
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            email = txtEmail.Text;
            sexe = txtSexe.Text;
            telephone = txtTel.Text;
            adresse = txtAdresse.Text;
            faculte = txtFaculte.Text;
            cours = txtCours.Text;
            mdp = txtMdp.Text;
            int status = 0;
            rmdp = txtRepeteMdp.Text;
            string matricule = GenererMatricule(nom, prenom);



            //verificarions des variables s'il ne sont pas vides
            if (nom == "") { ShowToast("INFO", "Veuillez remplir le champ nom"); txtNom.Focus(); }
            else if (prenom == "") { ShowToast("INFO", "Veuillez remplir le champ prénom"); txtPrenom.Focus(); }
            else if (email == "") { ShowToast("INFO", "Veuillez remplir le champ email"); txtEmail.Focus(); }
            else if (sexe == "" || sexe == "Choisir") { ShowToast("INFO", "Veuillez choisir un option dans le champs sexe"); txtSexe.Focus(); }
            else if (telephone == "") { ShowToast("INFO", "Veuillez remplir le champ téléphone"); txtTel.Focus(); }
            else if (adresse == "") { ShowToast("INFO", "Veuillez remplir le champ adresse"); txtAdresse.Focus(); }
            else if (cours == "") { ShowToast("INFO", "Veuillez choisir un option dans le champ cours"); txtCours.Focus(); }
            else if (faculte == "" || faculte == "Choisir") { ShowToast("INFO", "Veuillez choisir un option dans le champ faculté"); txtCours.Focus(); }
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

                    string query = "INSERT INTO enseignant (code,nom,prenom,email,adresse,sexe,cours,faculte,telephone,mdp,photos,status) VALUES (@code,@nom,@prenom,@email,@adresse,@sexe,@cours,@faculte,@telephone,@mdp,@photos,@status)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parameters

                    // Parameters
                    command.Parameters.AddWithValue("@code", matricule);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@adresse", adresse);
                    command.Parameters.AddWithValue("@telephone", telephone);
                    command.Parameters.AddWithValue("@sexe", sexe);
                    command.Parameters.AddWithValue("@faculte", faculte);
                    command.Parameters.AddWithValue("@cours", cours);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@mdp", mdp);
                    command.Parameters.AddWithValue("@photos", images);
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

        private void txtFaculte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Effacer les éléments précédemment chargés dans le ComboBox des cours
            txtCours.Items.Clear();

            // Récupérer les facultes sélectionné dans le ComboBox des facultes
            string selectedCours = txtFaculte.SelectedItem.ToString();

            // Vérifier si la faculte sélectionné a des cours associes
            if (Faculte.ContainsKey(selectedCours))
            {
                // Charger les cours associées dans le ComboBox des cours
                txtCours.Items.AddRange(Faculte[selectedCours].ToArray());
            }
            else
            {
                // Si aucune correspondance n'est trouvée, afficher un message
                txtCours.Items.Add("Aucun cours n'est disponible");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnseignantForm_Load(object sender, EventArgs e)
        {
            txtSexe.SelectedIndex = 0;
            txtFaculte.SelectedIndex = 0;
            if (formVerification == 1)
            {
                btnBack.Show();
            }
            else
            {
                btnBack.Hide();
            }
        }
    }
}
