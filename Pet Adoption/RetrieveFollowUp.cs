using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class RetrieveFollowUp : Form
    {
        public RetrieveFollowUp()
        {
            InitializeComponent();
        }

        private void RetrieveFollowUp_Load(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter an employee ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string query = "SELECT a.employeeID, a.adopterID, a.followUpDate, a.notes, ad.adopterName, ad.adopterAdress " +
                                   "FROM AdoptionFollowUp a " +
                                   "JOIN Adopter ad ON a.adopterID = ad.adopterID " +
                                   "WHERE a.employeeID = @employeeID";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        
                        cmd.Parameters.AddWithValue("@employeeID", searchQuery);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                resultsPanel.Controls.Clear();

                               
                                while (reader.Read())
                                {
                                    
                                    Panel card = CreateFollowUpCard(
                                        reader["employeeID"].ToString(),
                                        reader["adopterID"].ToString(),
                                        reader["followUpDate"].ToString(),
                                        reader["notes"].ToString(),
                                        reader["adopterName"].ToString(),
                                        reader["adopterAdress"].ToString()
                                    );

                                    
                                    resultsPanel.Controls.Add(card);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No follow-ups found for the given employee ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private Panel CreateFollowUpCard(string employeeID, string adopterID, string followUpDate, string notes, string adopterName, string adopterAddress)
        {
            
            Panel card = new Panel
            {
                Size = new Size(400, 200),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10)
            };

            
            Label employeeLabel = new Label
            {
                Text = $"Employee ID: {employeeID}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label adopterLabel = new Label
            {
                Text = $"Adopter: {adopterName}",
                Location = new Point(10, 40),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label followUpDateLabel = new Label
            {
                Text = $"Follow-up Date: {followUpDate}",
                Location = new Point(10, 70),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label notesLabel = new Label
            {
                Text = $"Notes: {notes}",
                Location = new Point(10, 100),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label addressLabel = new Label
            {
                Text = $"Address: {adopterAddress}",
                Location = new Point(10, 130),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            
            card.Controls.Add(employeeLabel);
            card.Controls.Add(adopterLabel);
            card.Controls.Add(followUpDateLabel);
            card.Controls.Add(notesLabel);
            card.Controls.Add(addressLabel);

            return card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffFollowUp staffFollowUp = new StaffFollowUp();
            staffFollowUp.Show();
            this.Hide();
        }
    }
}
