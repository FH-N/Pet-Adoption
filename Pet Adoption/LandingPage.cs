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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void employeebutton_Click(object sender, EventArgs e)
        {
            ShelterEmployeeForm shelterForm = new ShelterEmployeeForm();
            shelterForm.Show();
            this.Hide();
        }

        private void adopter_Click_1(object sender, EventArgs e)
        {
            //SearchAnimals searchAnimal = new SearchAnimals();
            //searchAnimal.Show();
            AdopterForm adopterForm = new AdopterForm();
            adopterForm.Show();
            this.Hide();
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void landingpage_Load(object sender, EventArgs e)
        {

        }
    }
}
