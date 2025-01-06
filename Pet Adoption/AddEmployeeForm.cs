using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pet_Adoption
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Text = string.Empty; 
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern) && txtEmail.Text.Length > 0)
            {
                lblEmailError.Text = "Invalid email format.";
                lblEmailError.ForeColor = System.Drawing.Color.Red;
                lblEmailError.Visible = true; 
            }
            else
            {
                lblEmailError.Text = ""; 
                lblEmailError.Visible = false; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }

        private void SaveEmployee()
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Please fill in all required fields (Name, Email, Salary).");
                return;
            }

            
            if (!int.TryParse(txtSalary.Text, out int salary))
            {
                MessageBox.Show("Salary must be a valid number.");
                return;
            }

            
            int? supervisorID = null;
            int? shelterID = null;

           
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string query = @"INSERT INTO Employee (employeeName, employeeEmail, employeeSalary)
                             VALUES (@name, @email, @salary)";

                    MySqlCommand cmd = new MySqlCommand(query, cnn);

                    
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    
                    cmd.ExecuteNonQuery();

                    
                    long employeeID = cmd.LastInsertedId;

                    
                    if (supervisorID.HasValue)
                    {
                        string supervisorQuery = @"INSERT INTO SupervisorAssignment (employeeID, supervisorID)
                                           VALUES (@employeeID, @supervisorID)";

                        MySqlCommand supervisorCmd = new MySqlCommand(supervisorQuery, cnn);
                        supervisorCmd.Parameters.AddWithValue("@employeeID", employeeID);
                        supervisorCmd.Parameters.AddWithValue("@supervisorID", supervisorID.Value);

                        supervisorCmd.ExecuteNonQuery();
                    }

                    
                    MessageBox.Show("Employee added successfully!");

                   
                    txtName.Clear();
                    txtEmail.Clear();
                    txtSalary.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SupervisorForm supervisorForm = new SupervisorForm();
            supervisorForm.Show();
            this.Hide();
        }
    }
}


        