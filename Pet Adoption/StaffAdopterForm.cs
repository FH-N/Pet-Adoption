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
    public partial class StaffAdopterForm : Form
    {
        public StaffAdopterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetrieveAdopter retrieveAdopter = new RetrieveAdopter();
            retrieveAdopter.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffFollowUp staffFollowUp = new StaffFollowUp();
            staffFollowUp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StahhHomePage stahhHomePage = new StahhHomePage();
            stahhHomePage.Show();
            this.Hide();
        }

        private void StaffAdopterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
