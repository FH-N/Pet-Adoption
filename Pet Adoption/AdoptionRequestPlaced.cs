using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Adoption
{
    public partial class AdoptionRequestPlaced : Form
    {
        private int loggedInAdopterID;
        private int animalID;

        
        private Label lblAdopterName, lblAdopterEmail, lblAdopterPhone, lblAdopterAddress, lblApplicationStatus;
        private Label lblAnimalName, lblAnimalSpecies, lblAnimalBreed, lblAnimalHealthStatus;
        private Label lblShelterName, lblShelterLocation;

        public AdoptionRequestPlaced(int loggedInAdopterID, int animalID)
        {
            InitializeComponent();
            this.loggedInAdopterID = loggedInAdopterID;
            this.animalID = animalID;

            // Initialize labels
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            
            lblAdopterName = new Label { Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(400, 20) };
            lblAdopterEmail = new Label { Location = new System.Drawing.Point(20, 50), Size = new System.Drawing.Size(400, 20) };
            lblAdopterPhone = new Label { Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(400, 20) };
            lblAdopterAddress = new Label { Location = new System.Drawing.Point(20, 110), Size = new System.Drawing.Size(400, 20) };
            lblApplicationStatus = new Label { Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(400, 20) };

            
            lblAnimalName = new Label { Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(400, 20) };
            lblAnimalSpecies = new Label { Location = new System.Drawing.Point(20, 210), Size = new System.Drawing.Size(400, 20) };
            lblAnimalBreed = new Label { Location = new System.Drawing.Point(20, 240), Size = new System.Drawing.Size(400, 20) };
            lblAnimalHealthStatus = new Label { Location = new System.Drawing.Point(20, 270), Size = new System.Drawing.Size(400, 20) };

            
            lblShelterName = new Label { Location = new System.Drawing.Point(20, 300), Size = new System.Drawing.Size(400, 20) };
            lblShelterLocation = new Label { Location = new System.Drawing.Point(20, 330), Size = new System.Drawing.Size(400, 20) };

            
            this.Controls.Add(lblAdopterName);
            this.Controls.Add(lblAdopterEmail);
            this.Controls.Add(lblAdopterPhone);
            this.Controls.Add(lblAdopterAddress);
            this.Controls.Add(lblApplicationStatus);
            this.Controls.Add(lblAnimalName);
            this.Controls.Add(lblAnimalSpecies);
            this.Controls.Add(lblAnimalBreed);
            this.Controls.Add(lblAnimalHealthStatus);
            this.Controls.Add(lblShelterName);
            this.Controls.Add(lblShelterLocation);
        }

        private void AdoptionRequestPlaced_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string adopterQuery = "SELECT adopterName, adopterEmail, adopterPhone_Number, adopterAdress, applicationStatus FROM Adopter WHERE adopterID = @adopterID";
                    using (MySqlCommand adopterCmd = new MySqlCommand(adopterQuery, cnn))
                    {
                        adopterCmd.Parameters.AddWithValue("@adopterID", loggedInAdopterID);

                        using (MySqlDataReader adopterReader = adopterCmd.ExecuteReader())
                        {
                            if (adopterReader.HasRows)
                            {
                                while (adopterReader.Read())
                                {
                                    
                                    lblAdopterName.Text = "Adopter Name: " + adopterReader["adopterName"].ToString();
                                    lblAdopterEmail.Text = "Email: " + adopterReader["adopterEmail"].ToString();
                                    lblAdopterPhone.Text = "Phone: " + adopterReader["adopterPhone_Number"].ToString();
                                    lblAdopterAddress.Text = "Address: " + adopterReader["adopterAdress"].ToString();
                                    lblApplicationStatus.Text = "Application Status: " + adopterReader["applicationStatus"].ToString();
                                }
                            }
                        }
                    }

                    
                    string animalQuery = @"
                        SELECT 
                            a.animalName, 
                            a.animalSpecies, 
                            a.animalBreed, 
                            a.animal_Health_Status, 
                            s.shelterName, 
                            s.shelterLocation
                        FROM Animal a
                        JOIN AnimalShelter ash ON a.animalID = ash.animalID
                        JOIN Shelter s ON ash.shelterID = s.shelterID
                        WHERE a.animalID = @animalID";
                    using (MySqlCommand animalCmd = new MySqlCommand(animalQuery, cnn))
                    {
                        animalCmd.Parameters.AddWithValue("@animalID", animalID);

                        using (MySqlDataReader animalReader = animalCmd.ExecuteReader())
                        {
                            if (animalReader.HasRows)
                            {
                                while (animalReader.Read())
                                {
                                    
                                    lblAnimalName.Text = "Animal Name: " + animalReader["animalName"].ToString();
                                    lblAnimalSpecies.Text = "Species: " + animalReader["animalSpecies"].ToString();
                                    lblAnimalBreed.Text = "Breed: " + animalReader["animalBreed"].ToString();
                                    lblAnimalHealthStatus.Text = "Health Status: " + animalReader["animal_Health_Status"].ToString();
                                    lblShelterName.Text = "Shelter: " + animalReader["shelterName"].ToString();
                                    lblShelterLocation.Text = "Location: " + animalReader["shelterLocation"].ToString();
                                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAnimals searchAnimals = new SearchAnimals(loggedInAdopterID);
            searchAnimals.Show();
            this.Hide();
        }
    }
}
