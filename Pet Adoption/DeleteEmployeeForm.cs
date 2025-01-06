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
    public partial class DeleteEmployeeForm : Form
    {
        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            string employeeID = textBoxEmployeeID.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(employeeID))
            {
                MessageBox.Show("Please enter an Employee ID.");
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
                DELETE FROM Employee
                WHERE employeeID = @employeeID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@employeeID", employeeID);

                        
                        int rowsAffected = command.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                            textBoxEmployeeID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
