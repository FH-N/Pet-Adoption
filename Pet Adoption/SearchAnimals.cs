using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class SearchAnimals : Form
    {
        private int loggedInAdopterID;
        public SearchAnimals(int adopterID)
        {
            InitializeComponent();
            loggedInAdopterID = adopterID;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a species or breed to search for!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string query = "SELECT animalID, animalName, animalSpecies, animalBreed, animalDateOfBirth, animal_Health_Status " +
                                   "FROM Animal " +
                                   "WHERE (animalSpecies = @searchQuery OR animalBreed = @searchQuery) AND animalAvailabilty = true;";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        
                        cmd.Parameters.AddWithValue("@searchQuery", searchQuery);

                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            flowLayoutPanelResults.Controls.Clear();

                            if (reader.HasRows)
                            {
                                
                                while (reader.Read())
                                {
                                    
                                    Panel animalCard = new Panel
                                    {
                                        Width = 250,
                                        Height = 400,  
                                        BorderStyle = BorderStyle.FixedSingle,
                                        Margin = new Padding(10),
                                        Padding = new Padding(10),
                                        BackColor = System.Drawing.Color.White  
                                    };

                                    
                                    TableLayoutPanel cardLayout = new TableLayoutPanel
                                    {
                                        Dock = DockStyle.Fill,
                                        RowCount = 6, 
                                        ColumnCount = 2,
                                        AutoSize = true,
                                        CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                                        Padding = new Padding(5)
                                    };

                                    
                                    cardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                                    cardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));

                                    
                                    cardLayout.Controls.Add(new Label { Text = "Name:", Anchor = AnchorStyles.Left }, 0, 0);
                                    cardLayout.Controls.Add(new Label { Text = reader["animalName"].ToString(), Anchor = AnchorStyles.Left }, 1, 0);

                                    
                                    cardLayout.Controls.Add(new Label { Text = "Species:", Anchor = AnchorStyles.Left }, 0, 1);
                                    cardLayout.Controls.Add(new Label { Text = reader["animalSpecies"].ToString(), Anchor = AnchorStyles.Left }, 1, 1);

                                    
                                    cardLayout.Controls.Add(new Label { Text = "Breed:", Anchor = AnchorStyles.Left }, 0, 2);
                                    cardLayout.Controls.Add(new Label { Text = reader["animalBreed"].ToString(), Anchor = AnchorStyles.Left }, 1, 2);

                                   
                                    cardLayout.Controls.Add(new Label { Text = "DOB:", Anchor = AnchorStyles.Left }, 0, 3);
                                    cardLayout.Controls.Add(new Label { Text = reader["animalDateOfBirth"].ToString(), Anchor = AnchorStyles.Left }, 1, 3);

                                   
                                    cardLayout.Controls.Add(new Label { Text = "Health Status:", Anchor = AnchorStyles.Left }, 0, 4);
                                    cardLayout.Controls.Add(new Label { Text = reader["animal_Health_Status"].ToString(), Anchor = AnchorStyles.Left }, 1, 4);

                                   
                                    Button requestButton = new Button
                                    {
                                        Text = "Request Adoption",
                                        AutoSize = true,
                                        Anchor = AnchorStyles.Left | AnchorStyles.Top,
                                        Margin = new Padding(10)
                                    };

                                    
                                    int animalID = Convert.ToInt32(reader["animalID"]);
                                    string animalName = reader["animalName"].ToString();

                                    requestButton.Click += (s, args) =>
                                    {
                                        
                                        string checkAdoptionQuery = "SELECT animalID FROM Adopter WHERE adopterID = @adopterID";

                                        using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                        {
                                            try
                                            {
                                                cnn2.Open();

                                                using (MySqlCommand checkAdopterCmd = new MySqlCommand(checkAdoptionQuery, cnn2))
                                                {
                                                    checkAdopterCmd.Parameters.AddWithValue("@adopterID", loggedInAdopterID);

                                                    
                                                    var result = checkAdopterCmd.ExecuteScalar();

                                                    if (result != DBNull.Value)
                                                    {
                                                       
                                                        MessageBox.Show("You already have an active adoption request. You cannot request another animal.", "Adoption Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return; 
                                                    }
                                                }

                                                
                                                using (MySqlTransaction transaction = cnn2.BeginTransaction())
                                                {
                                                    
                                                    string updateAnimalQuery = "UPDATE Animal SET animalAvailabilty = false WHERE animalID = @animalID";
                                                    using (MySqlCommand updateAnimalCmd = new MySqlCommand(updateAnimalQuery, cnn2, transaction))
                                                    {
                                                        updateAnimalCmd.Parameters.AddWithValue("@animalID", animalID);
                                                        updateAnimalCmd.ExecuteNonQuery();
                                                    }

                                                    
                                                    string updateAdopterQuery = "UPDATE Adopter SET applicationStatus = 'In Progress', animalID = @animalID WHERE adopterID = @adopterID";
                                                    using (MySqlCommand updateAdopterCmd = new MySqlCommand(updateAdopterQuery, cnn2, transaction))
                                                    {
                                                        updateAdopterCmd.Parameters.AddWithValue("@adopterID", loggedInAdopterID);
                                                        updateAdopterCmd.Parameters.AddWithValue("@animalID", animalID);
                                                        updateAdopterCmd.ExecuteNonQuery();
                                                    }

                                                    
                                                    transaction.Commit();
                                                }

                                                
                                                MessageBox.Show("Adoption request sent for: " + animalName, "Adoption Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                AdoptionRequestPlaced adoptionRequest = new AdoptionRequestPlaced(loggedInAdopterID, animalID);
                                                adoptionRequest.Show();
                                                this.Hide();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    };


                                    
                                    cardLayout.Controls.Add(requestButton, 0, 5);
                                    cardLayout.SetColumnSpan(requestButton, 2); 

                                    
                                    animalCard.Controls.Add(cardLayout);

                                   
                                    flowLayoutPanelResults.Controls.Add(animalCard);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No animals found matching the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void flowLayoutPanelResults_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchAnimals_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdopterHomePage adopterHomePage = new AdopterHomePage(loggedInAdopterID);
            adopterHomePage.Show();
            this.Hide();
        }
    }
}
