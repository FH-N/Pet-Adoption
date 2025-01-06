namespace Pet_Adoption
{
    partial class AddTreatmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTreatmentName = new MaskedTextBox();
            label1 = new Label();
            label3 = new Label();
            textBoxAnimalName = new TextBox();
            label4 = new Label();
            buttonAddTreatment = new Button();
            dateTimePickerTreatmentDate = new DateTimePicker();
            textBoxShelterName = new TextBox();
            AnimalName = new Label();
            SuspendLayout();
            // 
            // textBoxTreatmentName
            // 
            textBoxTreatmentName.Location = new Point(248, 86);
            textBoxTreatmentName.Name = "textBoxTreatmentName";
            textBoxTreatmentName.Size = new Size(336, 31);
            textBoxTreatmentName.TabIndex = 0;
            textBoxTreatmentName.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 92);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Treatment Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 197);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Treatment Date";
            // 
            // textBoxAnimalName
            // 
            textBoxAnimalName.Location = new Point(248, 288);
            textBoxAnimalName.Name = "textBoxAnimalName";
            textBoxAnimalName.Size = new Size(336, 31);
            textBoxAnimalName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 381);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 7;
            label4.Text = "Shelter Name";
            // 
            // buttonAddTreatment
            // 
            buttonAddTreatment.Location = new Point(308, 435);
            buttonAddTreatment.Name = "buttonAddTreatment";
            buttonAddTreatment.Size = new Size(186, 34);
            buttonAddTreatment.TabIndex = 8;
            buttonAddTreatment.Text = "Add Treatment";
            buttonAddTreatment.UseVisualStyleBackColor = true;
            buttonAddTreatment.Click += buttonAddTreatment_Click;
            // 
            // dateTimePickerTreatmentDate
            // 
            dateTimePickerTreatmentDate.Location = new Point(248, 192);
            dateTimePickerTreatmentDate.Name = "dateTimePickerTreatmentDate";
            dateTimePickerTreatmentDate.Size = new Size(336, 31);
            dateTimePickerTreatmentDate.TabIndex = 10;
            // 
            // textBoxShelterName
            // 
            textBoxShelterName.Location = new Point(248, 375);
            textBoxShelterName.Name = "textBoxShelterName";
            textBoxShelterName.Size = new Size(336, 31);
            textBoxShelterName.TabIndex = 11;
            // 
            // AnimalName
            // 
            AnimalName.AutoSize = true;
            AnimalName.Location = new Point(78, 291);
            AnimalName.Name = "AnimalName";
            AnimalName.Size = new Size(124, 25);
            AnimalName.TabIndex = 12;
            AnimalName.Text = "Aminal Name ";
            // 
            // AddTreatmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(AnimalName);
            Controls.Add(textBoxShelterName);
            Controls.Add(dateTimePickerTreatmentDate);
            Controls.Add(buttonAddTreatment);
            Controls.Add(label4);
            Controls.Add(textBoxAnimalName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxTreatmentName);
            Name = "AddTreatmentForm";
            Text = "AddTreatmentForm";
            Load += AddTreatmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox textBoxTreatmentName;
        private Label label1;
        private Label label3;
        private TextBox textBoxAnimalName;
        private Label label4;
        private Button buttonAddTreatment;
        private Label label2;
        private ComboBox comboBoxTreatmentType;
        private DateTimePicker dateTimePickerTreatmentDate;
        private TextBox textBoxShelterName;
        private Label AnimalName;
    }
}