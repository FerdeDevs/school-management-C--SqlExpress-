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
    public partial class splash : Form
    {
   
    
      // string[] names =  { "Ferdelson Paul", "Jean-Baptiste Wisnel", "Petit-Frère Wood Florensky"};
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
           // timer1.Interval = 10;
            timer1.Start();
            lblAfficher.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = progressBar.Value + 1;

            if (progressBar.Value <= 0)
            {
                lblName.Text = "";                
            }
            else if (progressBar.Value <= 10)
            {
                lblName.Text = "Petit-Frère Wood Florensky ";

            }
            else if (progressBar.Value <= 30)
            {

                lblName.Text = "Paul Ferdelson ";
            }
            else if (progressBar.Value <= 60)
            {
                lblName.Text = "Wisnel Jean-Baptiste";
            }
            else if (progressBar.Value <= 90)
            {

                label2.Text = "";
                lblName.Text = "Initialisation...";
            }
            else if (progressBar.Value <= 95)
            {

                label2.Text = "";
                lblName.Text = "Démarage du logiciel...";
            }
            else if (progressBar.Value >= 100)
            {
            }
            else
            {
                timer1.Stop();
                login form = new login();
                form.Show();
                this.Hide();
            }
        }



   
    }
}
