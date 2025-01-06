using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class AdopterAdoptionStatus : Form
    {
        private int loggedInAdopterID;
        public AdopterAdoptionStatus(int adopterID)
        {
            InitializeComponent();
            loggedInAdopterID = adopterID;
            LoadAdoptionStatus();
        }

        private void LoadAdoptionStatus()
        {
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string query = "SELECT a.applicationStatus, an.animalName, an.animalSpecies, an.animalBreed, an.animalDateOfBirth, an.animal_Health_Status " +
                                   "FROM Adopter a " +
                                   "LEFT JOIN Animal an ON a.animalID = an.animalID " +
                                   "WHERE a.adopterID = @adopterID";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        
                        cmd.Parameters.AddWithValue("@adopterID", loggedInAdopterID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int yOffset = 10; 

                                while (reader.Read())
                                {
                                    
                                    Panel adoptionInfoPanel = new Panel
                                    {
                                        Width = 350,
                                        Height = 250,
                                        BorderStyle = BorderStyle.FixedSingle,
                                        Padding = new Padding(10),
                                        Location = new Point(10, yOffset)
                                    };

                                    
                                    Label applicationStatusLabel = new Label
                                    {
                                        Text = $"Application Status: {reader["applicationStatus"].ToString()}",
                                        AutoSize = true,
                                        Location = new Point(10, 10)
                                    };

                                    adoptionInfoPanel.Controls.Add(applicationStatusLabel);

                                    
                                    if (reader["animalName"] != DBNull.Value)
                                    {
                                        Label animalNameLabel = new Label
                                        {
                                            Text = $"Name: {reader["animalName"].ToString()}",
                                            AutoSize = true,
                                            Location = new Point(10, 40)
                                        };

                                        Label animalSpeciesLabel = new Label
                                        {
                                            Text = $"Species: {reader["animalSpecies"].ToString()}",
                                            AutoSize = true,
                                            Location = new Point(10, 70)
                                        };

                                        Label animalBreedLabel = new Label
                                        {
                                            Text = $"Breed: {reader["animalBreed"].ToString()}",
                                            AutoSize = true,
                                            Location = new Point(10, 100)
                                        };

                                        Label animalDOBLabel = new Label
                                        {
                                            Text = $"Date of Birth: {reader["animalDateOfBirth"].ToString()}",
                                            AutoSize = true,
                                            Location = new Point(10, 130)
                                        };

                                        Label animalHealthStatusLabel = new Label
                                        {
                                            Text = $"Health Status: {reader["animal_Health_Status"].ToString()}",
                                            AutoSize = true,
                                            Location = new Point(10, 160)
                                        };

                                        
                                        adoptionInfoPanel.Controls.Add(animalNameLabel);
                                        adoptionInfoPanel.Controls.Add(animalSpeciesLabel);
                                        adoptionInfoPanel.Controls.Add(animalBreedLabel);
                                        adoptionInfoPanel.Controls.Add(animalDOBLabel);
                                        adoptionInfoPanel.Controls.Add(animalHealthStatusLabel);
                                    }
                                    else
                                    {
                                        Label noAnimalLabel = new Label
                                        {
                                            Text = "No animal associated with this adopter yet.",
                                            AutoSize = true,
                                            Location = new Point(10, 40)
                                        };

                                        adoptionInfoPanel.Controls.Add(noAnimalLabel);
                                    }

                                    
                                    this.Controls.Add(adoptionInfoPanel);

                                    
                                    yOffset += adoptionInfoPanel.Height + 20; 
                                }
                            }
                            else
                            {
                                MessageBox.Show("No adoption data found for this adopter.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void AdopterAdoptionStatus_Load(object sender, EventArgs e)
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