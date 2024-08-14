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
    public partial class SinglePayrollForm : Form
    {
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        string ID, table, codeEco, nbrHrs, mntParHrs;

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        public SinglePayrollForm(string NID, string Ntable, string NcodeEco)
        {
            InitializeComponent();
            ID = NID;
            table = Ntable;
            codeEco = NcodeEco;
        }

        private void SinglePayrollForm_Load(object sender, EventArgs e)
        {
            if (table == "admin")
            {
                searchData("admin",ID);
                panel2.Hide();
            }
            else if (table == "econome")
            {
                searchData("econome", ID);
                panel2.Hide();
            }
            else if (table == "enseignant")
            {
                searchData("enseignant", ID);
            }
            else if (table == "secretaire")
            {
                searchData("secretaire", ID);
                panel2.Hide();
            }
            else { }

            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM payroll WHERE codeEmp = '" + ID + "' AND employer = '" + table + "'";


            //5. Executer la requete
            SqlDataAdapter adap = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adap.Fill(data);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                     nbrHrs = row["heures"].ToString();
                     mntParHrs = row["montantHrs"].ToString();
                }
            }
            txtNmbreHeures.Text = nbrHrs;
            txtMontant.Text = mntParHrs;
        }

        void searchData(string table, string ID)
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            if (table == "admin")
            {
                //4. Requete
                string query = "SELECT * FROM admin WHERE code = '"+ID+"'";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCode.Text = reader["code"].ToString();
                    txtNom.Text = reader["nom"].ToString();
                    txtPrenom.Text = reader["prenom"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtTel.Text = reader["telephone"].ToString();
                    txtSexe.Text = reader["sexe"].ToString();
                    //adresse = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfileUpdate.Image = Image.FromStream(ms);
                    }
                }
            }
            else if (table == "econome")
            {
                //4. Requete
                string query = "SELECT * FROM econome WHERE code = '" + ID + "'";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCode.Text = reader["code"].ToString();
                    txtNom.Text = reader["nom"].ToString();
                    txtPrenom.Text = reader["prenom"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtTel.Text = reader["telephone"].ToString();
                    txtSexe.Text = reader["sexe"].ToString();
                    //adresse = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfileUpdate.Image = Image.FromStream(ms);
                    }
                }

            }
            else if (table == "enseignant")
            {
                //4. Requete
                string query = "SELECT * FROM enseignant WHERE code = '" + ID + "'";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCode.Text = reader["code"].ToString();
                    txtNom.Text = reader["nom"].ToString();
                    txtPrenom.Text = reader["prenom"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtFaculte.Text  = reader["faculte"].ToString();
                    txtCours.Text = reader["cours"].ToString();
                    txtTel.Text = reader["telephone"].ToString();
                    txtSexe.Text = reader["sexe"].ToString();
                    //adresse = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfileUpdate.Image = Image.FromStream(ms);
                    }
                }

            }
            else if (table == "secretaire")
            {
                //4. Requete
                string query = "SELECT * FROM secretaire WHERE code = '" + ID + "'";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCode.Text = reader["code"].ToString();
                    txtNom.Text = reader["nom"].ToString();
                    txtPrenom.Text = reader["prenom"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtTel.Text = reader["telephone"].ToString();
                    txtSexe.Text = reader["sexe"].ToString();
                    //adresse = reader["adresse"].ToString();
                    byte[] imageBytes = (byte[])reader["photos"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picProfileUpdate.Image = Image.FromStream(ms);
                    }
                }

             }
            else
            {
            }
            //6. Connection fermer
            connection.Close();
        }

        public void clear()
        {
            txtNmbreHeures.Text = "";
            txtMontant.Text = "";
        }

        public void payrollQuery(string table, string id,string nbrh,string mntant) {

            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM payroll WHERE codeEmp = '" + id + "' AND codeEco = '" + codeEco + "'";
            
           
            //5. Executer la requete
            SqlDataAdapter adap = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adap.Fill(data);

            //6. Recuperer l'heure, generer code auto, convertir et multiplier l'heure,montant en decimal
            
                //Convertir l'heure travailler,montant en decimal
                decimal nbr = decimal.Parse(nbrh);
                decimal mnt = decimal.Parse(mntant);
                decimal montant = nbr * mnt;
             

                //Generer un code automatique
                Random random = new Random();
                int rand = random.Next(100, 1000);
                string codeID = rand.ToString();

                //Recuperer l'heure de l'ordinateur
                DateTime now = DateTime.Now;
                string dateNow = now.ToString("le : dd-MM-yyyy -a- HH:mm");


            //7. inserer si on trouve un employer, sinon modifier                   
            if (data.Rows.Count > 0)
            {
                //8. Requete de mise-a-jour
                foreach (DataRow row in data.Rows)
                {
                    string codeBDD = row["code"].ToString();
                    if (txtNmbreHeures.Text == "") 
                    {
                        nbr = decimal.Parse(row["heures"].ToString());                            
                    }
                    else if (txtMontant.Text == "")
                    {
                         mnt = decimal.Parse(row["montantHrs"].ToString()); 
                    }
                    else { }
                    string updateQuery = "UPDATE payroll SET heures = @heures , montantHrs = @montantHrs , montant = @montant , codeEco = @codeEco , date = @date WHERE code = @code AND codeEmp = @codeEmp AND employer = @employer";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@code", codeBDD);
                    command.Parameters.AddWithValue("@employer", table);
                    command.Parameters.AddWithValue("@heures", nbr);
                    command.Parameters.AddWithValue("@montantHrs", mnt);
                    command.Parameters.AddWithValue("@codeEmp", id);
                    command.Parameters.AddWithValue("@montant", montant);
                    command.Parameters.AddWithValue("@codeEco", codeEco);
                    command.Parameters.AddWithValue("@date", dateNow);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            ShowToast("SUCCESS", "Paiement réussie");
                        }
                        else
                        {
                            ShowToast("ERROR", "Paiement échouée");
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
               

                //9. Si l'etudiant n'a pas encore de notes
                string queryInsert = "INSERT INTO payroll (code,employer,heures,montantHrs,codeEmp,montant,codeEco,date) VALUES (@code,@employer,@heures,@montantHrs,@codeEmp,@montant,@codeEco,@date)";

                //10. Executer la requete
                SqlCommand command = new SqlCommand(queryInsert, connection);
                command.Parameters.AddWithValue("@code", codeID);
                command.Parameters.AddWithValue("@employer", table);
                command.Parameters.AddWithValue("@heures", nbr);
                command.Parameters.AddWithValue("@montantHrs", mnt);
                command.Parameters.AddWithValue("@codeEmp", id);
                command.Parameters.AddWithValue("@montant", montant);
                command.Parameters.AddWithValue("@codeEco", codeEco);
                command.Parameters.AddWithValue("@date", dateNow);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ShowToast("SUCCESS", "Paiement réussie");
                    }
                    else
                    {
                        ShowToast("ERROR", "Paiement échouée");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
           string nbrh = txtNmbreHeures.Text;
           string mntant = txtMontant.Text;
           if (txtNmbreHeures.Text == "")
           {
               ShowToast("WARNING", "Champs nombres heures vide");
           }
           else if (txtMontant.Text == "")
           { 
               ShowToast("WARNING", "Champs montant/heures vide "); 
           }
           else
           {
               if (table == "admin")
               {
                   payrollQuery("admin", ID, nbrh, mntant);
                   panel2.Hide();
               }
               else if (table == "econome")
               {
                   payrollQuery("econome", ID, nbrh, mntant);
                   panel2.Hide();
               }
               else if (table == "enseignant")
               {
                   payrollQuery("enseignant", ID, nbrh, mntant);
                   panel2.Hide();
               }
               else if (table == "secretaire")
               {
                   payrollQuery("secretaire", ID, nbrh, mntant);
                   panel2.Hide();
               }
               else { }
           }
            
        }

        private void txtNmbreHeures_Enter(object sender, EventArgs e)
        {
            if (txtNmbreHeures.Text == nbrHrs)
            {
                txtNmbreHeures.Text = "";
                txtNmbreHeures.ForeColor = Color.Black;
            }
        }

        private void txtNmbreHeures_Leave(object sender, EventArgs e)
        {
            if (txtNmbreHeures.Text == "")
            {
                txtNmbreHeures.Text = nbrHrs;
                txtNmbreHeures.ForeColor = Color.Gray;
            }
        }

        private void txtMontant_Enter(object sender, EventArgs e)
        {
            if (txtMontant.Text == mntParHrs)
            {
                txtMontant.Text = "";
                txtMontant.ForeColor = Color.Black;
            }
        }

        private void txtMontant_Leave(object sender, EventArgs e)
        {
            if (txtMontant.Text == "")
            {
                txtMontant.Text = mntParHrs;
                txtMontant.ForeColor = Color.Gray;
            }
        }
    }
}
