using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class RetrieveAdopter : Form
    {
        public RetrieveAdopter()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter an adopter name or ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    string query = "SELECT adopterID, adopterName, adopterEmail, adopterPhone_Number, adopterAdress, applicationStatus, adoptionDate, animalID " +
                                   "FROM Adopter " +
                                   "WHERE adopterID = @searchQuery OR adopterName = @searchQuery";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@searchQuery", searchQuery);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                
                                resultsPanel.Controls.Clear();

                                
                                while (reader.Read())
                                {
                                    
                                    Panel card = CreateAdopterCard(
                                        reader["adopterID"].ToString(),
                                        reader["adopterName"].ToString(),
                                        reader["adopterEmail"].ToString(),
                                        reader["adopterPhone_Number"].ToString(),
                                        reader["adopterAdress"].ToString(),
                                        reader["applicationStatus"].ToString(),
                                        reader["adoptionDate"].ToString(),
                                        reader["animalID"].ToString()
                                    );

                                    
                                    resultsPanel.Controls.Add(card);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No adopter found with the provided ID or name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Panel CreateAdopterCard(
            string adopterID, string adopterName, string adopterEmail, string adopterPhone,
            string adopterAddress, string applicationStatus, string adoptionDate, string animalID)
        {
            
            Panel card = new Panel
            {
                Size = new Size(400, 200),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10)
            };

            
            Label idLabel = new Label
            {
                Text = $"ID: {adopterID}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label nameLabel = new Label
            {
                Text = $"Name: {adopterName}",
                Location = new Point(10, 40),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label emailLabel = new Label
            {
                Text = $"Email: {adopterEmail}",
                Location = new Point(10, 70),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label phoneLabel = new Label
            {
                Text = $"Phone: {adopterPhone}",
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

            Label statusLabel = new Label
            {
                Text = $"Status: {applicationStatus}",
                Location = new Point(200, 10),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label dateLabel = new Label
            {
                Text = $"Date: {adoptionDate}",
                Location = new Point(200, 40),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Label animalLabel = new Label
            {
                Text = $"Animal ID: {animalID}",
                Location = new Point(200, 70),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            Button editButton = new Button
            {
                Text = "Edit Status",
                Location = new Point(200, 130),
                Size = new Size(100, 30),
                BackColor = Color.LightGray,
                Font = new Font("Arial", 9, FontStyle.Regular)
            };

            
            editButton.Click += (sender, e) => EditAdoptionStatus(adopterID);

            
            card.Controls.Add(idLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(emailLabel);
            card.Controls.Add(phoneLabel);
            card.Controls.Add(addressLabel);
            card.Controls.Add(statusLabel);
            card.Controls.Add(dateLabel);
            card.Controls.Add(animalLabel);
            card.Controls.Add(editButton);

            return card;
        }

        private void RetrieveAdopter_Load(object sender, EventArgs e)
        {

        }

        private void EditAdoptionStatus(string adopterID)
        {
            string newStatus = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the new adoption status (e.g., Accepted, Rejected, In Progress):",
                "Edit Adoption Status",
                "");

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Adoption status cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string updateAdopterQuery = "UPDATE Adopter SET applicationStatus = @newStatus WHERE adopterID = @adopterID";
                    using (MySqlCommand cmd = new MySqlCommand(updateAdopterQuery, cnn))
                    {
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.Parameters.AddWithValue("@adopterID", adopterID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Adoption status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            if (newStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase))
                            {
                                UpdateAnimalAndClearAdopterAnimalID(cnn, adopterID);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update adoption status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateAnimalAndClearAdopterAnimalID(MySqlConnection cnn, string adopterID)
        {
            try
            {
                
                string fetchAnimalQuery = "SELECT animalID FROM Adopter WHERE adopterID = @adopterID";
                using (MySqlCommand fetchCmd = new MySqlCommand(fetchAnimalQuery, cnn))
                {
                    fetchCmd.Parameters.AddWithValue("@adopterID", adopterID);

                    object animalIDObj = fetchCmd.ExecuteScalar();
                    if (animalIDObj != null)
                    {
                        string animalID = animalIDObj.ToString();

                        
                        string updateAnimalQuery = "UPDATE Animal SET animalAvailabilty = TRUE WHERE animalID = @animalID";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateAnimalQuery, cnn))
                        {
                            updateCmd.Parameters.AddWithValue("@animalID", animalID);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Animal availability updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update animal availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                       
                        string clearAnimalIDQuery = "UPDATE Adopter SET animalID = NULL WHERE adopterID = @adopterID";
                        using (MySqlCommand clearCmd = new MySqlCommand(clearAnimalIDQuery, cnn))
                        {
                            clearCmd.Parameters.AddWithValue("@adopterID", adopterID);

                            int rowsAffected = clearCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Animal ID cleared from adopter record.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to clear animal ID from adopter record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No animal associated with this adopter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffAdopterForm staffAdopterForm = new StaffAdopterForm();
            staffAdopterForm.Show();
            this.Hide();
        }
    }
}
