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
    public partial class MenuForm : Form
    {
      
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        string message = "Voulez-vous déconnecter de l'application ?";
        string title = "Déconnecter de l'application";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        string code, nom, prenom, email, sexe, adresse,cours,faculte, telephone, role;
        byte[] imageBytes;

        public MenuForm(string Ncode, string Nnom, string Nprenom, string Nemail, string Nsexe, string Nadresse,string Ncours,string Nfaculte, string Ntelephone, byte[] NimageBytes, string Nrole)
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


         private void MenuForm_Load(object sender, EventArgs e)
         {
             if (role == "enseignant")
             {
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();

                 btnDashboard.Show();
                 btnAdmin.Hide();
                 btnEconome.Hide();
                 btnEnseignant.Hide();
                 btnSecretaire.Hide();
                 btnEtudiant.Hide();
                 btnApprove.Hide();
                 btnNote.Show();
                 btnPaiementEtudiant.Hide();
                 btnPayroll.Hide();

             }
             else if (role == "admin")
             {

                 mainPanel.Hide();
                 btnDashboard.Show();
                 btnAdmin.Show();
                 btnEconome.Show();
                 btnEnseignant.Show();
                 btnSecretaire.Show();
                 btnEtudiant.Hide();
                 btnApprove.Show();
                 btnNote.Hide();
                 btnPaiementEtudiant.Hide();
                 btnPayroll.Hide();
             }
             else if (role == "secretaire")
             {
                 cours = "";
                 faculte = "";
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();

                 btnDashboard.Show();
                 btnAdmin.Hide();
                 btnEconome.Hide();
                 btnEnseignant.Hide();
                 btnSecretaire.Hide();
                 btnEtudiant.Show();
                 btnApprove.Hide();
                 btnNote.Hide();
                 btnPaiementEtudiant.Hide();
                 btnPayroll.Hide();
             }
             else if (role == "econome")
             {
                 cours = "";
                 faculte = "";
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();

                 btnDashboard.Show();
                 btnAdmin.Hide();
                 btnEconome.Hide();
                 btnEnseignant.Hide();
                 btnSecretaire.Hide();
                 btnEtudiant.Hide();
                 btnApprove.Hide();
                 btnNote.Hide();
                 btnPaiementEtudiant.Show();
                 btnPayroll.Show();
             }
             else 
             {
                 mainPanel.Hide();
                 btnDashboard.Hide();
                 btnAdmin.Hide();
                 btnEconome.Hide();
                 btnEnseignant.Hide();
                 btnSecretaire.Hide();
                 btnEtudiant.Hide();
                 btnApprove.Hide();
                 btnNote.Hide();
                 btnPaiementEtudiant.Hide();
                 btnPayroll.Hide();
             }
             using (MemoryStream ms = new MemoryStream(imageBytes))
             {
                 picProfileDashboard.Image = Image.FromStream(ms);
             }


             chart1.Series[0].Points.AddXY("Etudiant", 70);
             chart1.Series[0].Points.AddXY("Professeur", 40);
             chart1.Series[0].Points.AddXY("Note", 60);
             chart1.Series[0].Points.AddXY("Cours", 30);

             chart1.Series[1].Points.AddXY("Etudiant", 35);
             chart1.Series[1].Points.AddXY("Professeur", 50);
             chart1.Series[1].Points.AddXY("Note", 60);
             chart1.Series[1].Points.AddXY("Cours", 45);

             chart1.Series[2].Points.AddXY("Etudiant", 70);
             chart1.Series[2].Points.AddXY("Professeur", 40);
             chart1.Series[2].Points.AddXY("Note", 30);
             chart1.Series[2].Points.AddXY("Cours", 50);

             lblRole.Text = role;
             lblUser.Text = email;
             lblUserName.Text = nom +" "+prenom;
                try
                 {
                     using (SqlConnection connection = new SqlConnection(connectionString))
                     {
                         connection.Open();

                         string query = "SELECT COUNT(*) FROM admin";

                         using (SqlCommand command = new SqlCommand(query, connection))
                         {
                             int rowCounts = (int)command.ExecuteScalar();
                             lblAdmin.Text = rowCounts.ToString();
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("An error occurred: " + ex);
                 }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM enseignant";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rowCounts = (int)command.ExecuteScalar();
                            lblEnseignant.Text = rowCounts.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex);
                }


                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM econome";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rowCounts = (int)command.ExecuteScalar();
                            lblEconome.Text = rowCounts.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex);
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM etudiant";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rowCounts = (int)command.ExecuteScalar();
                            lblEtudiant.Text = rowCounts.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex);
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM secretaire";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rowCounts = (int)command.ExecuteScalar();
                            lblSecretaire.Text = rowCounts.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex);
                }
            
         }

         private void btnDashboard_Click(object sender, EventArgs e)
         {
             if (role == "admin")
             {
                 mainPanel.Hide();
                 // MenuForm.Show();
                 AdminDashboardForm child = new AdminDashboardForm() { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();
             }
             else if (role == "enseignant")
             {
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();
             }
             else if (role == "secretaire")
             {
                 cours = "";
                 faculte = "";
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();
             }
             else if (role == "econome")
             {
                 cours = "";
                 faculte = "";
                 mainPanel.Show();
                 FORM child = new FORM(code, nom, prenom, email, sexe, adresse, cours, faculte, telephone, imageBytes, role) { TopLevel = false, TopMost = true };
                 child.FormBorderStyle = FormBorderStyle.None;
                 mainPanel.Controls.Add(child);
                 child.Show();
                 child.BringToFront();
             }
             else { }
      

         }

         private void btnProfile_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             int verification = 1;
             UserProfilForm child = new UserProfilForm(code,role,verification) { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnAdmin_Click(object sender, EventArgs e)
         {    mainPanel.Show();
             AdminDashboardForm child = new AdminDashboardForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnEnseignant_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             EnseignantDashboardForm child = new EnseignantDashboardForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnSecretaire_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             SecretaireDashboardForm child = new SecretaireDashboardForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnEconome_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             EconomeDashboardForm child = new EconomeDashboardForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnEtudiant_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             EtudiantDashboardForm child = new EtudiantDashboardForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnApprove_Click(object sender, EventArgs e)
         {
              mainPanel.Show();
             ApproveForm child = new ApproveForm() { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnNote_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             NoteDashboardForm child = new NoteDashboardForm(role,code,faculte,cours) { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnDeconnecter_Click(object sender, EventArgs e)
         {
             DialogResult result = MessageBox.Show(message, title, buttons);
             if (result == DialogResult.Yes)
             {
                 login form = new login();
                 form.Show();
                 this.Close();
             } 
         }

         private void btnPaiementEtudiant_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             PaiementEtudiantDashboardForm child = new PaiementEtudiantDashboardForm(code,nom,prenom,email) { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

         private void btnPayroll_Click(object sender, EventArgs e)
         {
             mainPanel.Show();
             PayrollForm child = new PayrollForm(code) { TopLevel = false, TopMost = true };
             child.FormBorderStyle = FormBorderStyle.None;
             mainPanel.Controls.Add(child);
             child.Show();
             child.BringToFront();
         }

    }
}
