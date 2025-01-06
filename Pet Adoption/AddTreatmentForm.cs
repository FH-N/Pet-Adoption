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
    public partial class AddTreatmentForm : Form
    {
        public AddTreatmentForm()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTreatment_Click(object sender, EventArgs e)
        {
            
            string treatmentDetails = textBoxTreatmentName.Text.Trim(); // Combined Treatment Name and Type
            DateTime treatmentDate = dateTimePickerTreatmentDate.Value;
            string animalName = textBoxAnimalName.Text.Trim();
            string shelterName = textBoxShelterName.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(treatmentDetails) ||
                string.IsNullOrWhiteSpace(animalName) ||
                string.IsNullOrWhiteSpace(shelterName))
            {
                MessageBox.Show("Please fill in all required fields (Treatment Details, Animal Name, and Shelter Name).",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = @"
                INSERT INTO MedicalHistory (treatmentDate, treatmentName, animalID)
                SELECT @treatmentDate, @treatmentDetails, a.animalID
                FROM Animal a
                JOIN AnimalShelter ans ON a.animalID = ans.animalID
                JOIN Shelter s ON ans.shelterID = s.shelterID
                WHERE a.animalName = @animalName AND s.shelterName = @shelterName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@treatmentDate", treatmentDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@treatmentDetails", treatmentDetails);
                        command.Parameters.AddWithValue("@animalName", animalName);
                        command.Parameters.AddWithValue("@shelterName", shelterName);

                        int rowsAffected = command.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Treatment added successfully!");
                            textBoxTreatmentName.Clear();
                            textBoxAnimalName.Clear();
                            textBoxShelterName.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No matching animal or shelter found. Please check your input.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddTreatmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
