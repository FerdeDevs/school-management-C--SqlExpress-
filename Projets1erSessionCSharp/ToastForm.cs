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
    public partial class ToastForm : Form
    {
        int toastX, toastY, Y = 100;
        public ToastForm(string type, string message)
        {
            InitializeComponent();
            lbType.Text = type;
            lbMessage.Text = message;
           
            switch (type)
            {
                  
                case "SUCCESS":
                    toastBorder.BackColor = Color.FromArgb(103, 192, 1);
                    picIcon.Image = Properties.Resources.success;
                    break;
                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(254, 72, 73);
                    picIcon.Image = Properties.Resources.error;
                    break;
                case "INFO":
                    toastBorder.BackColor = Color.FromArgb(37, 150, 190);
                    picIcon.Image = Properties.Resources.info;
                    break;
                case "WARNING":
                    toastBorder.BackColor = Color.FromArgb(239, 205, 1);
                    picIcon.Image = Properties.Resources.warning;
                    break;
            }
        }
        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 20;
            toastY = ScreenHeight - this.Height - 20;


            this.Location = new Point(toastX, toastY);  

        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
            this.BringToFront();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY >= 100)
            {
                toastTimer.Stop(); 
                toastHide.Start();
            }
        }

        private void toastHide_Tick(object sender, EventArgs e)
        {
            Y--;
            if (Y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY +=10);
                if (toastY > 800)
                {
                    toastHide.Stop();
                    Y = 100;
                    this.Close();
                }
            }
        }

    
    }
}
