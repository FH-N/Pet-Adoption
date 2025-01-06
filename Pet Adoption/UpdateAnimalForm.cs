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
    public partial class UpdateAnimalForm : Form
    {
        public UpdateAnimalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string animalName = textBoxSearchAnimalName.Text.Trim();
            string shelterName = textBoxSearchShelterName.Text.Trim();

            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(shelterName))
            {
                MessageBox.Show("Please provide both the Animal Name and Shelter Name to search.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
                SELECT 
                    a.animalSpecies, 
                    a.animalBreed, 
                    a.animal_Health_Status, 
                    a.animalDateOfBirth 
                FROM 
                    Animal a
                INNER JOIN AnimalShelter ashel ON a.animalID = ashel.animalID
                INNER JOIN Shelter s ON ashel.shelterID = s.shelterID
                WHERE 
                    a.animalName = @animalName
                    AND s.shelterName = @shelterName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@animalName", animalName);
                        command.Parameters.AddWithValue("@shelterName", shelterName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                textBoxSpecies.Text = reader["animalSpecies"].ToString();
                                textBoxBreed.Text = reader["animalBreed"].ToString();
                                textBoxHealthStatus.Text = reader["animal_Health_Status"].ToString();
                                dateTimePickerDateOfBirth.Value = reader["animalDateOfBirth"] == DBNull.Value
                                    ? DateTime.Now
                                    : Convert.ToDateTime(reader["animalDateOfBirth"]);

                                MessageBox.Show("Animal details loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No matching animal found. Please check the details and try again.", "Animal Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            string animalName = textBoxSearchAnimalName.Text.Trim();
            string shelterName = textBoxSearchShelterName.Text.Trim();
            string species = textBoxSpecies.Text.Trim();
            string breed = textBoxBreed.Text.Trim();
            string healthStatus = textBoxHealthStatus.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;

            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(shelterName))
            {
                MessageBox.Show("Please search for an animal first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
               UPDATE Animal a
                INNER JOIN AnimalShelter ashel ON a.animalID = ashel.animalID
                INNER JOIN Shelter s ON ashel.shelterID = s.shelterID
                SET 
                    a.animalSpecies = @species,
                    a.animalBreed = @breed,
                    a.animal_Health_Status = @healthStatus,
                    a.animalDateOfBirth = @dateOfBirth
                WHERE 
                    a.animalName = @animalName
                    AND s.shelterName = @shelterName";


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@animalName", animalName);
                        command.Parameters.AddWithValue("@shelterName", shelterName);
                        command.Parameters.AddWithValue("@species", string.IsNullOrEmpty(species) ? DBNull.Value : (object)species);
                        command.Parameters.AddWithValue("@breed", string.IsNullOrEmpty(breed) ? DBNull.Value : (object)breed);
                        command.Parameters.AddWithValue("@healthStatus", string.IsNullOrEmpty(healthStatus) ? DBNull.Value : (object)healthStatus);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching animal found. Please check the details and try again.", "Animal Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAnimalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
