using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Adoption
{
    public partial class RetrieveEmployeeForm : Form
    {
        public RetrieveEmployeeForm()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();
            LoadEmployeeData(searchName);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter a name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadEmployeeData(searchName);
        }

        private void LoadEmployeeData(string searchName)
        {
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    string query = @"
                        SELECT 
                            e.employeeID AS 'Employee ID',
                            e.employeeName AS 'Employee Name',
                            e.employeeEmail AS 'Email',
                            e.employeeSalary AS 'Salary',
                            s.shelterName AS 'Shelter Name',
                            supervisor.employeeName AS 'Supervisor Name'
                        FROM Employee e
                        LEFT JOIN Shelter s ON e.employeeID = s.shelterID 
                        LEFT JOIN SupervisorAssignment sa ON e.employeeID = sa.employeeID
                        LEFT JOIN Employee supervisor ON sa.supervisorID = supervisor.employeeID
                        LEFT JOIN EmployeeShelter es ON e.employeeID = es.employeeID
                        WHERE e.employeeName LIKE @searchName";

                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@searchName", $"%{searchName}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No employees found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        return;
                    }

                    
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervisorForm supervisorForm = new SupervisorForm();
            supervisorForm.Show();
            this.Hide();
        }

        private void RetrieveEmployeeForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
