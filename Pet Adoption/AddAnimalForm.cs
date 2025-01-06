using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void AddAnimalButton_Click_1(object sender, EventArgs e)
        {
 
            string name = AnimalNameTextBox.Text.Trim();
            string species = AnimalSpeciesTextBox.Text.Trim();
            string breed = AnimalBreedTextBox.Text.Trim();
            string healthStatus = AnimalHealthStatusTextBox.Text.Trim();
            DateTime dateOfBirth = AnimalDateOfBirthPicker.Value;
            int shelterID = int.Parse(ShelterIDTextBox.Text.Trim());

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    string animalQuery = @"
                        INSERT INTO Animal 
                        (animalName, animalSpecies, animalBreed, animalDateOfBirth, animal_Health_Status, animalAvailabilty) 
                        VALUES 
                        (@name, @species, @breed, @dateOfBirth, @healthStatus, TRUE)";

                    using (MySqlCommand command = new MySqlCommand(animalQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@species", species);
                        command.Parameters.AddWithValue("@breed", breed);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@healthStatus", healthStatus);

                        
                        command.ExecuteNonQuery();
                    }

                    string shelterQuery = @"
                        INSERT INTO AnimalShelter (animalID, shelterID) 
                        VALUES 
                        (LAST_INSERT_ID(), @shelterID)";

                    using (MySqlCommand command = new MySqlCommand(shelterQuery, connection))
                    {
                        command.Parameters.AddWithValue("@shelterID", shelterID);

                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Animal added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization logic can go here
        }
    }
}
