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
    public partial class StahhHomePage : Form
    {
        public StahhHomePage()
        {
            InitializeComponent();
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
            this.Hide();
        }

        private void adopterButton_Click(object sender, EventArgs e)
        {
            StaffAdopterForm staffAdopterFOrm = new StaffAdopterForm();
            staffAdopterFOrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShelterEmployeeForm shelterEmployeeForm = new ShelterEmployeeForm();
            shelterEmployeeForm.Show();
            this.Hide();
        }
    }
}
