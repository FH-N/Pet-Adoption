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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pet_Adoption
{
    public partial class AdopterForm : Form
    {
        public AdopterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string adopterName = nameTextBox.Text;
            string adopterEmail = emailTextBox.Text;
            string adopterPhoneNum = phoneNumTextBox.Text;
            string adopterAddress = addressTextBox.Text;

           
            if (string.IsNullOrEmpty(adopterName) || string.IsNullOrEmpty(adopterEmail) ||
                string.IsNullOrEmpty(adopterPhoneNum) || string.IsNullOrEmpty(adopterAddress))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    
                    string query = "INSERT INTO Adopter (adopterName, adopterEmail, adopterPhone_Number, adopterAdress) " +
                                   "VALUES (@adopterName, @adopterEmail, @adopterPhoneNum, @adopterAddress); " +
                                   "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                       
                        cmd.Parameters.AddWithValue("@adopterName", adopterName);
                        cmd.Parameters.AddWithValue("@adopterEmail", adopterEmail);
                        cmd.Parameters.AddWithValue("@adopterPhoneNum", adopterPhoneNum);
                        cmd.Parameters.AddWithValue("@adopterAddress", adopterAddress);

                        
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int adopterID = Convert.ToInt32(result);

                           
                            MessageBox.Show("Adopter inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            nameTextBox.Clear();
                            emailTextBox.Clear();
                            phoneNumTextBox.Clear();
                            addressTextBox.Clear();

                            
                            AdopterHomePage adopterHomePage = new AdopterHomePage(adopterID);
                            adopterHomePage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve Adopter ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string adopterEmail = logInEmailtextBox.Text;

            if (string.IsNullOrEmpty(adopterEmail))
            {
                MessageBox.Show("Email is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    // SQL query to retrieve adopter details
                    string query = "SELECT adopterID, adopterName, adopterPhone_Number, adopterAdress " +
                                   "FROM Adopter WHERE adopterEmail = @adopterEmail";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        // Bind parameters
                        cmd.Parameters.AddWithValue("@adopterEmail", adopterEmail);

                        // Execute the query and read the results
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the adopter details
                                int adopterID = Convert.ToInt32(reader["adopterID"]);
                                string name = reader["adopterName"].ToString();
                                string phoneNumber = reader["adopterPhone_Number"].ToString();
                                string address = reader["adopterAdress"].ToString();

                                AdopterHomePage adopterHomePage = new AdopterHomePage(adopterID);
                                adopterHomePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                // No adopter found
                                MessageBox.Show("No adopter found with the provided email.",
                                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logInEmailtextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

        private void AdopterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
