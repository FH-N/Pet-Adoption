namespace Pet_Adoption
{
    partial class UpdateAnimalForm
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
            textBoxSearchAnimalName = new TextBox();
            label1 = new Label();
            textBoxSearchShelterName = new TextBox();
            label2 = new Label();
            buttonSearch = new Button();
            textBoxSpecies = new TextBox();
            label3 = new Label();
            textBoxBreed = new TextBox();
            label4 = new Label();
            textBoxHealthStatus = new TextBox();
            label5 = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            label6 = new Label();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // textBoxSearchAnimalName
            // 
            textBoxSearchAnimalName.Location = new Point(193, 90);
            textBoxSearchAnimalName.Margin = new Padding(2, 2, 2, 2);
            textBoxSearchAnimalName.Name = "textBoxSearchAnimalName";
            textBoxSearchAnimalName.Size = new Size(339, 27);
            textBoxSearchAnimalName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Search Animal Name";
            label1.Click += label1_Click;
            // 
            // textBoxSearchShelterName
            // 
            textBoxSearchShelterName.Location = new Point(193, 140);
            textBoxSearchShelterName.Margin = new Padding(2, 2, 2, 2);
            textBoxSearchShelterName.Name = "textBoxSearchShelterName";
            textBoxSearchShelterName.Size = new Size(339, 27);
            textBoxSearchShelterName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 3;
            label2.Text = "Search Shelter Name";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(255, 213);
            buttonSearch.Margin = new Padding(2, 2, 2, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(90, 27);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSpecies
            // 
            textBoxSpecies.Location = new Point(193, 319);
            textBoxSpecies.Margin = new Padding(2, 2, 2, 2);
            textBoxSpecies.Name = "textBoxSpecies";
            textBoxSpecies.Size = new Size(317, 27);
            textBoxSpecies.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 322);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 6;
            label3.Text = "Animal Species";
            // 
            // textBoxBreed
            // 
            textBoxBreed.Location = new Point(193, 386);
            textBoxBreed.Margin = new Padding(2, 2, 2, 2);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(317, 27);
            textBoxBreed.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 391);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "Animal Breed";
            label4.Click += label4_Click;
            // 
            // textBoxHealthStatus
            // 
            textBoxHealthStatus.Location = new Point(193, 464);
            textBoxHealthStatus.Margin = new Padding(2, 2, 2, 2);
            textBoxHealthStatus.Name = "textBoxHealthStatus";
            textBoxHealthStatus.Size = new Size(317, 27);
            textBoxHealthStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 469);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 10;
            label5.Text = "Health Status";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(193, 534);
            dateTimePickerDateOfBirth.Margin = new Padding(2, 2, 2, 2);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(317, 27);
            dateTimePickerDateOfBirth.TabIndex = 11;
            dateTimePickerDateOfBirth.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 538);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 12;
            label6.Text = "Date of Birth";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(255, 592);
            buttonUpdate.Margin = new Padding(2, 2, 2, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(90, 27);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // UpdateAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 655);
            Controls.Add(buttonUpdate);
            Controls.Add(label6);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(label5);
            Controls.Add(textBoxHealthStatus);
            Controls.Add(label4);
            Controls.Add(textBoxBreed);
            Controls.Add(label3);
            Controls.Add(textBoxSpecies);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(textBoxSearchShelterName);
            Controls.Add(label1);
            Controls.Add(textBoxSearchAnimalName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateAnimalForm";
            Text = "UpdateAnimalForm";
            Load += UpdateAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchAnimalName;
        private Label label1;
        private TextBox textBoxSearchShelterName;
        private Label label2;
        private Button buttonSearch;
        private TextBox textBoxSpecies;
        private Label label3;
        private TextBox textBoxBreed;
        private Label label4;
        private TextBox textBoxHealthStatus;
        private Label label5;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label label6;
        private Button buttonUpdate;
    }
}