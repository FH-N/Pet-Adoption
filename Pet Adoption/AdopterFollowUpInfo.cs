using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class AdopterFollowUpInfo : Form
    {
        private int loggedInAdopterID;

        public AdopterFollowUpInfo(int adopterID)
        {
            InitializeComponent();
            loggedInAdopterID = adopterID;

            
            LoadFollowUpInfo();
        }

        private void LoadFollowUpInfo()
        {
            string connectionString = "Server=localhost;Database=pet_adoption_system;Uid=newuser;Pwd=adoptionpass;";

            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    
                    string query = "SELECT af.followUpDate, af.notes, e.employeeName " +
                                   "FROM AdoptionFollowUp af " +
                                   "JOIN Employee e ON af.employeeID = e.employeeID " +
                                   "WHERE af.adopterID = @adopterID " +
                                   "ORDER BY af.followUpDate DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                       
                        cmd.Parameters.AddWithValue("@adopterID", loggedInAdopterID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            this.Controls.Clear();

                            int yPosition = 10; 

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    
                                    Panel followUpCard = new Panel
                                    {
                                        Size = new Size(600, 150), 
                                        Location = new Point(10, yPosition),
                                        BorderStyle = BorderStyle.FixedSingle,
                                        Padding = new Padding(10),
                                    };

                                    
                                    Label followUpDateLabel = new Label
                                    {
                                        Text = $"Follow-Up Date: {reader["followUpDate"].ToString()}",
                                        AutoSize = true,
                                        Font = new Font("Arial", 10, FontStyle.Bold)
                                    };
                                    followUpCard.Controls.Add(followUpDateLabel);

                                    
                                    Label employeeNameLabel = new Label
                                    {
                                        Text = $"Employee: {reader["employeeName"].ToString()}",
                                        AutoSize = true,
                                        Font = new Font("Arial", 9, FontStyle.Regular),
                                        Location = new Point(0, followUpDateLabel.Bottom + 5)
                                    };
                                    followUpCard.Controls.Add(employeeNameLabel);

                                    
                                    Label notesLabel = new Label
                                    {
                                        Text = $"Notes: {reader["notes"].ToString()}",
                                        AutoSize = true,
                                        Font = new Font("Arial", 9, FontStyle.Regular),
                                        Location = new Point(0, employeeNameLabel.Bottom + 5)
                                    };
                                    followUpCard.Controls.Add(notesLabel);

                                    
                                    this.Controls.Add(followUpCard);

                                    
                                    yPosition += followUpCard.Height + 10;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No follow-up records found for this adopter.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdopterFollowUpInfo_Load(object sender, EventArgs e)
        {
            // Additional logic can be added here if needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdopterHomePage adopterHomePage = new AdopterHomePage(loggedInAdopterID);
            adopterHomePage.Show();
            this.Hide();
        }
    }
}
