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
    public partial class AddFollowUp : Form
    {
        public AddFollowUp()
        {
            InitializeComponent();
        }

        private void AddFollowUp_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int employeeID = int.Parse(employeeIDTextBox.Text);
            int adopterID = int.Parse(adopterIDTextBox.Text);
            DateTime followUpDate = followUpDatePicker.Value;
            string notes = notesTextBox.Text;

            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    string insertQuery = "INSERT INTO AdoptionFollowUp (employeeID, adopterID, followUpDate, notes) " +
                                         "VALUES (@employeeID, @adopterID, @followUpDate, @notes)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, cnn))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.Parameters.AddWithValue("@adopterID", adopterID);
                        cmd.Parameters.AddWithValue("@followUpDate", followUpDate);
                        cmd.Parameters.AddWithValue("@notes", notes);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Follow-up added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffFollowUp staffFollowUp = new StaffFollowUp();
            staffFollowUp.Show();
            this.Hide();
        }
    }
}
