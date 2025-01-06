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
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetrieveEmployeeForm retrieveEmployeeForm = new RetrieveEmployeeForm();
            retrieveEmployeeForm.Show();
           
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShelterEmployeeForm shelterEmployeeForm = new ShelterEmployeeForm();
            shelterEmployeeForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm();
            updateEmployeeForm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteEmployeeForm deleteEmployeeForm = new DeleteEmployeeForm();
            deleteEmployeeForm.Show();
            
        }
    }
}
