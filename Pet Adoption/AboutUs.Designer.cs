namespace Pet_Adoption
{
    partial class AboutUs
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
            titlelabel = new Label();
            sheltNumLabel = new Label();
            animalNumLabel = new Label();
            adoptSuccLabel = new Label();
            availableAnimalsLabel = new Label();
            popularBreedLabel = new Label();
            mostPopSpeciesLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.Location = new Point(301, 29);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(168, 20);
            titlelabel.TabIndex = 0;
            titlelabel.Text = "PET ADOPTION SYSTEM";
            // 
            // sheltNumLabel
            // 
            sheltNumLabel.AutoSize = true;
            sheltNumLabel.Location = new Point(85, 113);
            sheltNumLabel.Name = "sheltNumLabel";
            sheltNumLabel.Size = new Size(140, 20);
            sheltNumLabel.TabIndex = 1;
            sheltNumLabel.Text = "Number of Shelters:";
            // 
            // animalNumLabel
            // 
            animalNumLabel.AutoSize = true;
            animalNumLabel.Location = new Point(85, 215);
            animalNumLabel.Name = "animalNumLabel";
            animalNumLabel.Size = new Size(141, 20);
            animalNumLabel.TabIndex = 2;
            animalNumLabel.Text = "Number of Animals:";
            // 
            // adoptSuccLabel
            // 
            adoptSuccLabel.AutoSize = true;
            adoptSuccLabel.Location = new Point(400, 113);
            adoptSuccLabel.Name = "adoptSuccLabel";
            adoptSuccLabel.Size = new Size(163, 20);
            adoptSuccLabel.TabIndex = 3;
            adoptSuccLabel.Text = "Adoption Success Rate:";
            // 
            // availableAnimalsLabel
            // 
            availableAnimalsLabel.AutoSize = true;
            availableAnimalsLabel.Location = new Point(85, 302);
            availableAnimalsLabel.Name = "availableAnimalsLabel";
            availableAnimalsLabel.Size = new Size(207, 20);
            availableAnimalsLabel.TabIndex = 4;
            availableAnimalsLabel.Text = "Number of Available Animals:";
            // 
            // popularBreedLabel
            // 
            popularBreedLabel.AutoSize = true;
            popularBreedLabel.Location = new Point(400, 215);
            popularBreedLabel.Name = "popularBreedLabel";
            popularBreedLabel.Size = new Size(142, 20);
            popularBreedLabel.TabIndex = 5;
            popularBreedLabel.Text = "Most Popular Breed:";
            // 
            // mostPopSpeciesLabel
            // 
            mostPopSpeciesLabel.AutoSize = true;
            mostPopSpeciesLabel.Location = new Point(400, 302);
            mostPopSpeciesLabel.Name = "mostPopSpeciesLabel";
            mostPopSpeciesLabel.Size = new Size(153, 20);
            mostPopSpeciesLabel.TabIndex = 6;
            mostPopSpeciesLabel.Text = "Most Popular Species:";
            // 
            // backButton
            // 
            backButton.Location = new Point(24, 396);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 7;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(mostPopSpeciesLabel);
            Controls.Add(popularBreedLabel);
            Controls.Add(availableAnimalsLabel);
            Controls.Add(adoptSuccLabel);
            Controls.Add(animalNumLabel);
            Controls.Add(sheltNumLabel);
            Controls.Add(titlelabel);
            Name = "AboutUs";
            Text = "Form2";
            Load += AboutUs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlelabel;
        private Label sheltNumLabel;
        private Label animalNumLabel;
        private Label adoptSuccLabel;
        private Label availableAnimalsLabel;
        private Label popularBreedLabel;
        private Label mostPopSpeciesLabel;
        private Button backButton;
    }
}