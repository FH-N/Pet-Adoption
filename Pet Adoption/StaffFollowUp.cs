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
    public partial class StaffFollowUp : Form
    {
        public StaffFollowUp()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddFollowUp addFollowUp = new AddFollowUp();
            addFollowUp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetrieveFollowUp retrieveFollowUp = new RetrieveFollowUp();
            retrieveFollowUp.Show();
            this.Hide();
        }

        private void StaffFollowUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffAdopterForm staffAdopterForm = new StaffAdopterForm();
            staffAdopterForm.Show();
            this.Hide();
        }
    }
}
