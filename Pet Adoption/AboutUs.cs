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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    string shelterQuery = "SELECT COUNT(*) AS TotalShelters FROM Shelter";
                    using (MySqlCommand cmd = new MySqlCommand(shelterQuery, cnn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int totalShelters = reader.GetInt32("TotalShelters");

                                    sheltNumLabel.Text = "Total Shelters: " + totalShelters.ToString();
                                }
                            }
                        }
                    }

                    string animalQuery = "SELECT COUNT(*) AS TotalAnimals FROM Animal";
                    using (MySqlCommand cmd = new MySqlCommand(animalQuery, cnn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int totalAnimals = reader.GetInt32("TotalAnimals");

                                    animalNumLabel.Text = "Total Animals: " + totalAnimals.ToString();
                                }
                            }
                        }
                    }

                    string availableAnimalQuery = "SELECT COUNT(*) AS TotalAvailableAnimals FROM Animal WHERE animalAvailabilty = true";
                    using (MySqlCommand cmd = new MySqlCommand(availableAnimalQuery, cnn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int totalAvailableAnimals = reader.GetInt32("TotalAvailableAnimals");

                                    availableAnimalsLabel.Text = "Total Available Animals: " + totalAvailableAnimals.ToString();
                                }
                            }
                        }
                    }


                    string adoptionSuccessQuery = "SELECT COUNT(*) AS AdoptionSuccessRate FROM Adopter WHERE applicationStatus = 'Accepted'";
                    using (MySqlCommand cmd = new MySqlCommand(adoptionSuccessQuery, cnn))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    
                                    int adoptionSuccessRate = reader.GetInt32("AdoptionSuccessRate");

                                    
                                    adoptSuccLabel.Text = "Adoption Success Rate: " + adoptionSuccessRate.ToString();
                                }
                            }
                        }
                    }

                    string mostPopBreedQuery = "SELECT animalBreed, COUNT(*) AS AdoptionCount FROM Animal JOIN Adopter ON animal.animalID = adopter.animalID WHERE applicationStatus = 'Accepted' GROUP BY animalBreed ORDER BY AdoptionCount DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(mostPopBreedQuery, cnn))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    
                                    string mostPopBreed = reader.GetString("animalBreed");

                                    
                                    popularBreedLabel.Text = "Most Adopted Breed: " + mostPopBreed;
                                }
                            }
                        }
                    }

                    string mostPopSpeciesQuery = "SELECT animalSpecies, COUNT(*) AS AdoptionCount FROM Animal JOIN Adopter ON animal.animalID = adopter.animalID WHERE applicationStatus = 'Accepted' GROUP BY animalSpecies ORDER BY AdoptionCount DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(mostPopSpeciesQuery, cnn))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    
                                    string mostPopSpecies = reader.GetString("animalSpecies");

                                    
                                    mostPopSpeciesLabel.Text = "Most Adopted Species: " + mostPopSpecies;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}
