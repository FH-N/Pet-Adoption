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
    public partial class RetrieveMedicalHistoryForm : Form
    {
        public RetrieveMedicalHistoryForm()
        {
            InitializeComponent();
        }

        private void textBoxAnimalName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string animalName = textBoxAnimalName.Text.Trim();

            if (string.IsNullOrWhiteSpace(animalName))
            {
                MessageBox.Show("Please enter an animal name to search.");
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

           
            string query = @"
                SELECT 
                    mh.treatmentDate AS 'Treatment Date',
                    mh.treatmentName AS 'Treatment Name',
                    a.animalName AS 'Animal Name'
                FROM MedicalHistory mh
                INNER JOIN Animal a ON mh.animalID = a.animalID
                WHERE a.animalName = @animalName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@animalName", animalName);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                               
                                dataGridViewMedicalHistory.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No medical history found for the specified animal.");
                                dataGridViewMedicalHistory.DataSource = null; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void RetrieveMedicalHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
