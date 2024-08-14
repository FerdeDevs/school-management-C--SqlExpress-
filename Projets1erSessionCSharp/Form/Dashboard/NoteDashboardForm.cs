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
    public partial class NoteDashboardForm : Form
    {
        //1. Connection Sql server
        public static string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=db_projet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        string code, role, faculte, cours;
        public NoteDashboardForm(string Nrole, string Ncode, string Nfaculte, string Ncours)
        {
            InitializeComponent();
            code = Ncode;
            role = Nrole;
            faculte = Nfaculte;
            cours = Ncours;
        }

        void searchData()
        {
            //2. Etablir la connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3. Ouvrir la conection 
            connection.Open();

            try
            {
                //4. Requete
                string query = "SELECT * FROM etudiant WHERE faculte = '" + faculte + "'";
                //5. Executer la requete
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                DataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridView.Rows.Add(reader["code"], reader["nom"], reader["prenom"], reader["email"], reader["sexe"], reader["faculte"], reader["adresse"], reader["telephone"]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }
            finally
            {
                //6. Connection fermer
                connection.Close();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "")
            {
                searchData();
            }
        }

        private void NoteDashboardForm_Load(object sender, EventArgs e)
        {
            searchData();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //1. Recuperer les donnees dans le dataGridView
                string codeEtu = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string noteEntree = DataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

                if (e.ColumnIndex == 9 && e.RowIndex > -1)
                {
                    DialogResult result = MessageBox.Show("Voulez vous Attribuer la note de : " + DataGridView.Rows[e.RowIndex].Cells[8].Value.ToString() + " pts de notes, au étudiant : " + DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), "Attribuer la note au étudiant matriculée " + DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //2. Etablir la connection
                        SqlConnection connection = new SqlConnection(connectionString);

                        //3. Ouvrir la conection 
                        connection.Open();

                        //4. Requete
                        string query = "SELECT * FROM notes WHERE code_professeur = '" + code + "' AND nom_cours = '" + cours + "' AND code_etudiant = '" + codeEtu + "'";

                        //5. Executer la requete
                        SqlDataAdapter adap = new SqlDataAdapter(query, connection);
                        DataTable data = new DataTable();
                        adap.Fill(data);

                        //6. Convertir la note en decimal
                        decimal newNote = decimal.Parse(noteEntree);

                        //7. inserer si on trouve un etudiant, sinon modifier                   
                        if (data.Rows.Count > 0)
                        {
                            //8. Requete de mise-a-jour
                            foreach (DataRow row in data.Rows)
                            {
                                string codeBDD = row["code"].ToString();

                                string updateQuery = "UPDATE notes SET note = @note WHERE code_professeur = @codeEns AND code = @code";
                                SqlCommand command = new SqlCommand(updateQuery, connection);
                                command.Parameters.AddWithValue("@codeEns", code);
                                command.Parameters.AddWithValue("@code", codeBDD);
                                command.Parameters.AddWithValue("@note", newNote);
                                try
                                {
                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        ShowToast("SUCCESS", "Note réussie");
                                    }
                                    else
                                    {
                                        ShowToast("ERROR", "Note échouée");
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
                            Random random = new Random();
                            int rand = random.Next(100, 1000);
                            string codeID = rand.ToString();

                            //9. Si l'etudiant n'a pas encore de notes
                            string queryInsert = "INSERT INTO notes (code,code_etudiant,code_professeur,nom_cours,note) VALUES (@code,@codeEtu,@codeEns,@cours,@note)";

                            //10. Executer la requete
                            SqlCommand command = new SqlCommand(queryInsert, connection);
                            command.Parameters.AddWithValue("@code", codeID);
                            command.Parameters.AddWithValue("@codeEtu", codeEtu);
                            command.Parameters.AddWithValue("@codeEns", code);
                            command.Parameters.AddWithValue("@cours", cours);
                            command.Parameters.AddWithValue("@note", newNote);
                            try
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    ShowToast("SUCCESS", "Note réussie");
                                }
                                else
                                {
                                    ShowToast("ERROR", "Note échouée");
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
            catch (Exception Ex)
            {
                MessageBox.Show("Vueillez saisie la note"+Ex);
            }

        }

    }
}



