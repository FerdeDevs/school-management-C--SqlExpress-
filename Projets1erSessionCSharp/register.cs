using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projets1erSessionCSharp
{
    public partial class register : Form
    {
        string message = "Voulez-vous déconnecter ?";
        string title = "Fermer fenêtre";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            mainPanel.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            int formVerification =0;
            mainPanel.Show();
            AdminForm child = new AdminForm(formVerification) { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(child);
            child.Show();
            child.BringToFront();
        }

        private void btnEnseignant_Click(object sender, EventArgs e)
        {
            int formVerification = 0;
            mainPanel.Show();
            EnseignantForm child = new EnseignantForm(formVerification) { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(child);
            child.Show();
            child.BringToFront();
        }

        private void btnSecretaire_Click(object sender, EventArgs e)
        {
            int formVerification = 0;
            mainPanel.Show();
            SecretaireForm child = new SecretaireForm(formVerification) { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(child);
            child.Show();
            child.BringToFront();
        }

        private void btnEconomat_Click(object sender, EventArgs e)
        {
            int formVerification = 0;
            mainPanel.Show();
            EconomeForm child = new EconomeForm(formVerification) { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(child);
            child.Show();
            child.BringToFront();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login form = new login();
                form.Show();
            } 
        
        }

     

                  
    }
}
