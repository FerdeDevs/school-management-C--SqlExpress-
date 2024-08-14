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

namespace Projets1erSessionCSharp
{
    public partial class PaiementEtudiant : Form
    {

        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        string ID, nom, prenom, faculte,codeSec, nomSec, prenomSec, emailSec;

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        public void ReloadData()
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            //4. Requete
            string query = "SELECT * FROM paiement WHERE code_etudiant = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(query, connection);

            //5. Executer la requete
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                decimal showBalance = Convert.ToDecimal(rd["balance"]);
                decimal showMontant = Convert.ToDecimal(rd["montant"]);
                lblGeneraux.Text = "Balance généraux : " + showBalance + "gds";
                lblMontant.Text = "Montant : " + showMontant + "gds";

                if (showMontant < 8000)
                {
                    lbl1.ForeColor = Color.DodgerBlue;
                }
                else if (showMontant == 8000)
                {
                    lbl1.ForeColor = Color.Green;
                }
                else if (showMontant <= 13000)
                {
                    lbl1.ForeColor = Color.Green;
                    lbl2.ForeColor = Color.DodgerBlue;
                }
                else if (showMontant <= 18000)
                {
                    lbl1.ForeColor = Color.Green;
                    lbl2.ForeColor = Color.Green;
                    lbl3.ForeColor = Color.DodgerBlue;
                }
                else if (showMontant <= 20000)
                {
                    lbl1.ForeColor = Color.Green;
                    lbl2.ForeColor = Color.Green;
                    lbl3.ForeColor = Color.Green;
                    lbl4.ForeColor = Color.DodgerBlue;
                }
                else if (showMontant == 20000)
                {
                    lbl1.ForeColor = Color.Green;
                    lbl2.ForeColor = Color.Green;
                    lbl3.ForeColor = Color.Green;
                    lbl4.ForeColor = Color.Green;
                }
                else
                {
                    lbl1.ForeColor = Color.Green;
                    lbl2.ForeColor = Color.Green;
                    lbl3.ForeColor = Color.Green;
                    lbl4.ForeColor = Color.Green;
                    lbl5.ForeColor = Color.Green;
                }
            }
            txtFaculter.Text = faculte;
            lblCode.Text = ID;
            lblNom.Text = nom;
            lblPrenom.Text = prenom;
            lblFaculte.Text = faculte;
            lblSecretaire.Text = emailSec;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
        }

        public PaiementEtudiant(string NewId, string Nnom, string Nprenom, string Nfac, string codeS, string nomS, string prenomS, string emailS)
        {
            InitializeComponent();
            ID = NewId;
            faculte = Nfac;
            nom = Nnom;
            prenom = Nprenom;
            codeSec = codeS;
            nomSec = nomS;
            prenomSec = prenomS;
            emailSec = emailS;
        }

        private void PaiementEtudiant_Load(object sender, EventArgs e)
        {
            ReloadData();    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            if (txtMontant.TextLength > 5)
            {
                ShowToast("INFO", "Maximum 5 chiffres.");
            }
            else
            {
                if (txtMontant.Text == "")
                {
                    ShowToast("INFO", "Veuillez remplir les champs correctement.");
                }
                else
                {
                    //2. Etablir la connection
                    SqlConnection connection = new SqlConnection(connectionString);

                    //3. Ouvrir la conection 
                    connection.Open();

                    //4. Requete
                    string query = "SELECT * FROM paiement WHERE code_etudiant = '" + ID + "' AND nom_etudiant = '" + nom + "' AND prenom_etudiant = '" + prenom + "'";

                    //5. Executer la requete
                    SqlDataAdapter adap = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();
                    adap.Fill(data);

                    //6. inserer si l'utilisateur n'existe pas sinon modifier
                    if (data.Rows.Count > 0)
                    {
                        //7. Modifier le montant et le balance si l'utilisateur existe
                        decimal montantEntree = decimal.Parse(txtMontant.Text);

                        //8. Recuperer le champs balance et le champs montant
                        foreach (DataRow row in data.Rows)
                        {
                            decimal montantRecup = Convert.ToDecimal(row["montant"]);
                            decimal balanceRecup = Convert.ToDecimal(row["balance"]);

                            decimal newMontant = montantEntree + montantRecup;
                            decimal newBalance = balanceRecup - montantEntree;

                            string updateQuery = "UPDATE paiement SET montant = @montant, balance = @balance WHERE code_etudiant = @code";
                            SqlCommand command = new SqlCommand(updateQuery, connection);
                            command.Parameters.AddWithValue("@montant", newMontant);
                            command.Parameters.AddWithValue("@balance", newBalance);
                            command.Parameters.AddWithValue("@code", ID);
                            try
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    ShowToast("SUCCESS", "Paiemenent réussie");
                                    ReloadData();
                                    txtMontant.Text = "";
                                }
                                else
                                {
                                    ShowToast("ERROR", "Paiemenent échouée");
                                    ReloadData();
                                    txtMontant.Text = "";
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
                        //9. Si l'etudiant n'existe pas encore a dans la table
                        decimal balance = 20000;
                        decimal montant = decimal.Parse(txtMontant.Text);
                        decimal newBalance =  balance - montant;

                        Random random = new Random();
                        int rand = random.Next(100, 1000);
                        string codeID = rand.ToString();

                        string insertQuery = "INSERT INTO paiement (Id,code_etudiant,nom_etudiant,prenom_etudiant,faculte_etudiant,montant,balance,code_secretaire) VALUES (@Id,@code,@nom,@prenom,@faculte,@montant,@balance,@codeSec)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@Id", codeID);
                        command.Parameters.AddWithValue("@code", ID);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@faculte", faculte);
                        command.Parameters.AddWithValue("@montant", montant);
                        command.Parameters.AddWithValue("@balance", newBalance);
                        command.Parameters.AddWithValue("@codeSec", codeSec);
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                ShowToast("SUCCESS", "Paiement réussie");
                                ReloadData();
                                txtMontant.Text = "";
                            }
                            else
                            {
                                ShowToast("ERROR", "Paiement échouée");
                                ReloadData();
                                txtMontant.Text = "";
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
        }
          
   
     }
}


