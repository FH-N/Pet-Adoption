namespace Pet_Adoption
{
    partial class AddAnimalForm
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
            components = new System.ComponentModel.Container();
            AnimalSpeciesLabel = new Label();
            AnimalDateOfBirthPicker = new DateTimePicker();
            AnimalNameTextBox = new TextBox();
            AnimalBreedLabel = new Label();
            DateOfBirthLabel = new Label();
            AnimalSpeciesTextBox = new TextBox();
            AddAnimalButton = new Button();
            AnimalNameLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShelterIDTextBox = new TextBox();
            AnimalBreedTextBox = new TextBox();
            AnimalHealthStatusTextBox = new TextBox();
            AnimalHealthStatusLabel = new Label();
            ShelterIDLabel = new Label();
            SuspendLayout();
            // 
            // AnimalSpeciesLabel
            // 
            AnimalSpeciesLabel.AutoSize = true;
            AnimalSpeciesLabel.Location = new Point(133, 83);
            AnimalSpeciesLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalSpeciesLabel.Name = "AnimalSpeciesLabel";
            AnimalSpeciesLabel.Size = new Size(114, 20);
            AnimalSpeciesLabel.TabIndex = 1;
            AnimalSpeciesLabel.Text = "Animal Species ";
            // 
            // AnimalDateOfBirthPicker
            // 
            AnimalDateOfBirthPicker.Location = new Point(133, 310);
            AnimalDateOfBirthPicker.Margin = new Padding(2, 2, 2, 2);
            AnimalDateOfBirthPicker.Name = "AnimalDateOfBirthPicker";
            AnimalDateOfBirthPicker.Size = new Size(263, 27);
            AnimalDateOfBirthPicker.TabIndex = 2;
            // 
            // AnimalNameTextBox
            // 
            AnimalNameTextBox.Location = new Point(133, 54);
            AnimalNameTextBox.Margin = new Padding(2, 2, 2, 2);
            AnimalNameTextBox.Name = "AnimalNameTextBox";
            AnimalNameTextBox.Size = new Size(258, 27);
            AnimalNameTextBox.TabIndex = 3;
            // 
            // AnimalBreedLabel
            // 
            AnimalBreedLabel.AutoSize = true;
            AnimalBreedLabel.Location = new Point(133, 158);
            AnimalBreedLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalBreedLabel.Name = "AnimalBreedLabel";
            AnimalBreedLabel.Size = new Size(103, 20);
            AnimalBreedLabel.TabIndex = 4;
            AnimalBreedLabel.Text = "Animal Breed ";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(131, 282);
            DateOfBirthLabel.Margin = new Padding(2, 0, 2, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(98, 20);
            DateOfBirthLabel.TabIndex = 5;
            DateOfBirthLabel.Text = "Date of birth ";
            // 
            // AnimalSpeciesTextBox
            // 
            AnimalSpeciesTextBox.Location = new Point(133, 114);
            AnimalSpeciesTextBox.Margin = new Padding(2, 2, 2, 2);
            AnimalSpeciesTextBox.Name = "AnimalSpeciesTextBox";
            AnimalSpeciesTextBox.Size = new Size(263, 27);
            AnimalSpeciesTextBox.TabIndex = 6;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(206, 442);
            AddAnimalButton.Margin = new Padding(2, 2, 2, 2);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(118, 27);
            AddAnimalButton.TabIndex = 7;
            AddAnimalButton.Text = "Add Animal";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click_1;
            // 
            // AnimalNameLabel
            // 
            AnimalNameLabel.AutoSize = true;
            AnimalNameLabel.Location = new Point(133, 14);
            AnimalNameLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalNameLabel.Name = "AnimalNameLabel";
            AnimalNameLabel.Size = new Size(100, 20);
            AnimalNameLabel.TabIndex = 8;
            AnimalNameLabel.Text = "Animal Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ShelterIDTextBox
            // 
            ShelterIDTextBox.Location = new Point(131, 245);
            ShelterIDTextBox.Margin = new Padding(2, 2, 2, 2);
            ShelterIDTextBox.Name = "ShelterIDTextBox";
            ShelterIDTextBox.Size = new Size(265, 27);
            ShelterIDTextBox.TabIndex = 10;
            // 
            // AnimalBreedTextBox
            // 
            AnimalBreedTextBox.Location = new Point(133, 184);
            AnimalBreedTextBox.Margin = new Padding(2, 2, 2, 2);
            AnimalBreedTextBox.Name = "AnimalBreedTextBox";
            AnimalBreedTextBox.Size = new Size(263, 27);
            AnimalBreedTextBox.TabIndex = 11;
            // 
            // AnimalHealthStatusTextBox
            // 
            AnimalHealthStatusTextBox.Location = new Point(133, 379);
            AnimalHealthStatusTextBox.Margin = new Padding(2, 2, 2, 2);
            AnimalHealthStatusTextBox.Name = "AnimalHealthStatusTextBox";
            AnimalHealthStatusTextBox.Size = new Size(263, 27);
            AnimalHealthStatusTextBox.TabIndex = 12;
            // 
            // AnimalHealthStatusLabel
            // 
            AnimalHealthStatusLabel.AutoSize = true;
            AnimalHealthStatusLabel.Location = new Point(133, 357);
            AnimalHealthStatusLabel.Margin = new Padding(2, 0, 2, 0);
            AnimalHealthStatusLabel.Name = "AnimalHealthStatusLabel";
            AnimalHealthStatusLabel.Size = new Size(97, 20);
            AnimalHealthStatusLabel.TabIndex = 13;
            AnimalHealthStatusLabel.Text = "Health Status";
            // 
            // ShelterIDLabel
            // 
            ShelterIDLabel.AutoSize = true;
            ShelterIDLabel.Location = new Point(133, 222);
            ShelterIDLabel.Margin = new Padding(2, 0, 2, 0);
            ShelterIDLabel.Name = "ShelterIDLabel";
            ShelterIDLabel.Size = new Size(74, 20);
            ShelterIDLabel.TabIndex = 14;
            ShelterIDLabel.Text = "Shelter ID";
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 491);
            Controls.Add(ShelterIDLabel);
            Controls.Add(AnimalHealthStatusLabel);
            Controls.Add(AnimalHealthStatusTextBox);
            Controls.Add(AnimalBreedTextBox);
            Controls.Add(ShelterIDTextBox);
            Controls.Add(AnimalNameLabel);
            Controls.Add(AddAnimalButton);
            Controls.Add(AnimalSpeciesTextBox);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(AnimalBreedLabel);
            Controls.Add(AnimalNameTextBox);
            Controls.Add(AnimalDateOfBirthPicker);
            Controls.Add(AnimalSpeciesLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            Load += AddAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AnimalSpeciesLabel;
        private DateTimePicker AnimalDateOfBirthPicker;
        private TextBox AnimalNameTextBox;
        private Label AnimalBreedLabel;
        private Label DateOfBirthLabel;
        private TextBox AnimalSpeciesTextBox;
        private Button AddAnimalButton;
        private Label AnimalNameLabel;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox ShelterIDTextBox;
        private TextBox AnimalBreedTextBox;
        private TextBox AnimalHealthStatusTextBox;
        private Label AnimalHealthStatusLabel;
        private Label ShelterIDLabel;
    }
}