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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            addAnimalForm.Show();
        }

        private void UpdateAnimalButton_Click(object sender, EventArgs e)
        {
            UpdateAnimalForm updateAnimalForm = new UpdateAnimalForm();
            updateAnimalForm.Show();
        }
        private void AddTreatementButton_Click(object sender, EventArgs e)
        {
            AddTreatmentForm addTreatmentForm = new AddTreatmentForm();
            addTreatmentForm.Show();
        }

        private void RetrieveMedicalHistoryButton_Click(object sender, EventArgs e)
        {
            RetrieveMedicalHistoryForm retrieveMedicalHistoryForm = new RetrieveMedicalHistoryForm();
            retrieveMedicalHistoryForm.Show();
        }


        private void StaffForm_Load(object sender, EventArgs e)
        {
            // Any additional logic for loading the form can be placed here.
        }

        private void AddTreatementButton_Click_1(object sender, EventArgs e)
        {
            AddTreatmentForm addTreatmentForm = new AddTreatmentForm();
            addTreatmentForm.Show();
        }

        private void DeleteAnimalButton_Click_1(object sender, EventArgs e)
        {
            DeleteAnimalForm deleteAnimalForm = new DeleteAnimalForm();
            deleteAnimalForm.Show();
        }


        private void RetrieveAnimalsButton_Click(object sender, EventArgs e)
        {
            RetrieveAnimalsForm retrieveAnimalsForm = new RetrieveAnimalsForm();
            retrieveAnimalsForm.Show();
        }

        private void StaffForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StahhHomePage stahhHomePage = new StahhHomePage();
            stahhHomePage.Show();
            this.Hide();
        }
    }
}
