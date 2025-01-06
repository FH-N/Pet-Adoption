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
    public partial class AdopterHomePage : Form
    {

        private int loggedInAdopterID;
        public AdopterHomePage(int adopterID)
        {
            InitializeComponent();
            loggedInAdopterID = adopterID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAnimals searchAnimals = new SearchAnimals(loggedInAdopterID);
            searchAnimals.Show();
            this.Hide();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            AdopterAdoptionStatus adoptionStatus = new AdopterAdoptionStatus(loggedInAdopterID);
            adoptionStatus.Show();
            this.Hide();
        }

        private void followUpButton_Click(object sender, EventArgs e)
        {
            AdopterFollowUpInfo followUpInfo = new AdopterFollowUpInfo(loggedInAdopterID);
            followUpInfo.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdopterForm adopterForm = new AdopterForm();
            adopterForm.Show();
            this.Hide();
        }

        private void AdopterHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
