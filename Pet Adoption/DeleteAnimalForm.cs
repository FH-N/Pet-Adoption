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
    public partial class DeleteAnimalForm : Form
    {
        public DeleteAnimalForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string animalName = textBoxAnimalName.Text.Trim();
            string shelterName = textBoxShelterName.Text.Trim();

            if (string.IsNullOrEmpty(animalName) || string.IsNullOrEmpty(shelterName))
            {
                MessageBox.Show("Please provide both the Animal Name and Shelter Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

           
            string query = @"
                DELETE a
                FROM Animal a
                JOIN AnimalShelter ans ON a.animalID = ans.animalID
                JOIN Shelter s ON ans.shelterID = s.shelterID
                WHERE a.animalName = @animalName
                  AND s.shelterName = @shelterName"; ;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@animalName", animalName);
                        command.Parameters.AddWithValue("@shelterName", shelterName);

                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteAnimalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
