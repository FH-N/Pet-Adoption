using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class RetrieveAnimalsForm : Form
    {
        public RetrieveAnimalsForm()
        {
            InitializeComponent();
        }

        private void RetrieveAnimalsForm_Load(object sender, EventArgs e)
        {
            LoadAnimalData(); 
        }

        private void LoadAnimalData(string searchCriteria = "")
        {
            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
                SELECT 
                    Animal.animalID AS 'Animal ID',
                    Animal.animalName AS 'Animal Name',
                    Animal.animalSpecies AS 'Species',
                    Animal.animalBreed AS 'Breed',
                    Animal.animalDateOfBirth AS 'Date of Birth',
                    Animal.animal_Health_Status AS 'Health Status',
                    Shelter.shelterName AS 'Shelter Name'
                FROM Animal
                LEFT JOIN AnimalShelter ON Animal.animalID = AnimalShelter.animalID
                LEFT JOIN Shelter ON AnimalShelter.shelterID = Shelter.shelterID
                WHERE (@search = '' OR Animal.animalName LIKE @search OR Animal.animalSpecies LIKE @search)
                ORDER BY Animal.animalID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@search", $"%{searchCriteria}%");

                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        
                        dataGridViewAnimals.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = textBoxSearch.Text.Trim();

            LoadAnimalData(searchCriteria);
        }

        private void dataGridViewAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        private void RetrieveAnimalsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
