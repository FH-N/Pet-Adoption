using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            
            string employeeID = textBoxEmployeeID.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeID))
            {
                MessageBox.Show("Please enter an employee ID to retrieve.");
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
                SELECT e.employeeName, e.employeeEmail, e.employeeSalary, sa.supervisorID, es.shelterID
                FROM Employee e
                LEFT JOIN SupervisorAssignment sa ON e.employeeID = sa.employeeID
                LEFT JOIN EmployeeShelter es ON e.employeeID = es.employeeID
                WHERE e.employeeID = @employeeID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@employeeID", employeeID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                textBoxName.Text = reader["employeeName"].ToString();
                                textBoxEmail.Text = reader["employeeEmail"].ToString();
                                textBoxSalary.Text = reader["employeeSalary"].ToString();
                                textBoxSupervisorID.Text = reader["supervisorID"].ToString();
                                textBoxShelterID.Text = reader["shelterID"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the specified ID.");
                                ClearFields();
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

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            
            string employeeID = textBoxEmployeeID.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeID))
            {
                MessageBox.Show("Please enter an employee ID.");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxSalary.Text))
            {
                MessageBox.Show("Please fill in all required fields (Name, Email, Salary).");
                return;
            }

           
            if (!int.TryParse(textBoxSalary.Text, out int salary))
            {
                MessageBox.Show("Salary must be a valid number.");
                return;
            }

            
            int? supervisorID = string.IsNullOrWhiteSpace(textBoxSupervisorID.Text) ? (int?)null : int.Parse(textBoxSupervisorID.Text);
            int? shelterID = string.IsNullOrWhiteSpace(textBoxShelterID.Text) ? (int?)null : int.Parse(textBoxShelterID.Text);

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            string query = @"
        UPDATE Employee
        SET employeeName = @name, employeeEmail = @email, employeeSalary = @salary
        WHERE employeeID = @employeeID;";

           
            if (supervisorID.HasValue)
            {
                query += @"
            INSERT INTO SupervisorAssignment (employeeID, supervisorID)
            VALUES (@employeeID, @supervisorID)
            ON DUPLICATE KEY UPDATE supervisorID = @supervisorID;";
            }

            
            query += @"
        INSERT INTO EmployeeShelter (employeeID, shelterID)
        VALUES (@employeeID, @shelterID)
        ON DUPLICATE KEY UPDATE shelterID = @shelterID;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                        {
                            
                            command.Parameters.AddWithValue("@employeeID", employeeID);
                            command.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
                            command.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                            command.Parameters.AddWithValue("@salary", salary);

                            
                            if (supervisorID.HasValue)
                            {
                                command.Parameters.AddWithValue("@supervisorID", supervisorID.Value);
                            }

                            
                            command.Parameters.AddWithValue("@shelterID", shelterID.HasValue ? shelterID.Value : DBNull.Value);

                            
                            int rowsAffected = command.ExecuteNonQuery();
                            transaction.Commit();

                            MessageBox.Show(rowsAffected > 0 ? "Employee updated successfully!" : "Failed to update employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void ClearFields()
        {
            // Clear all input fields
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxSalary.Clear();
            textBoxShelterID.Clear();
            textBoxSupervisorID.Clear();
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
