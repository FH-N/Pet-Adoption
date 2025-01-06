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
    public partial class ShelterEmployeeForm : Form
    {
        public ShelterEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervisorForm supervisorForm = new SupervisorForm();
            supervisorForm.Show();
            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StahhHomePage stahhHomePage = new StahhHomePage();
            stahhHomePage.Show();
            this.Hide();
        }

        private void ShelterEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}
