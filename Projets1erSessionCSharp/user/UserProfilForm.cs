using Projets1erSessionCSharp.user.userEdit;
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
    public partial class UserProfilForm : Form
    {
        string IdEdit, role;
        int verification;
        public UserProfilForm(string Ncode, string Nrole,int Nver)
        {
            InitializeComponent();
            IdEdit = Ncode;
            role = Nrole;
            verification = Nver;
        
        }

        private void UserProfilForm_Load(object sender, EventArgs e)
        {
            if (role == "enseignant")
            {
                EnseignantEdit child = new EnseignantEdit(IdEdit, verification) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                FormPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();
            }
            else if (role == "admin")
            {
                AdminEdit child = new AdminEdit(IdEdit, verification) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                FormPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();
            }
            else if (role == "secretaire")
            {
                SecretaireEdit child = new SecretaireEdit(IdEdit, verification) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                FormPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();
            }
            else if (role == "econome")
            {
                EconomeEdit child = new EconomeEdit(IdEdit, verification) { TopLevel = false, TopMost = true };
                child.FormBorderStyle = FormBorderStyle.None;
                FormPanel.Controls.Add(child);
                child.Show(); ;
                child.BringToFront();
            }
            else { }
        }
    }
}
