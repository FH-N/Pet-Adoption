namespace Pet_Adoption
{
    partial class StaffForm
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
            AddAnimalButton = new Button();
            RetrieveAnimalsButton = new Button();
            DeleteAnimalButton = new Button();
            UpdateAnimalButton = new Button();
            AddTreatementButton = new Button();
            RetrieveMedicalHistoryButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(211, 18);
            AddAnimalButton.Margin = new Padding(2);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(174, 27);
            AddAnimalButton.TabIndex = 0;
            AddAnimalButton.Text = "Add Animal";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // RetrieveAnimalsButton
            // 
            RetrieveAnimalsButton.Location = new Point(211, 74);
            RetrieveAnimalsButton.Margin = new Padding(2);
            RetrieveAnimalsButton.Name = "RetrieveAnimalsButton";
            RetrieveAnimalsButton.Size = new Size(174, 27);
            RetrieveAnimalsButton.TabIndex = 1;
            RetrieveAnimalsButton.Text = "Retrieve Animal ";
            RetrieveAnimalsButton.UseVisualStyleBackColor = true;
            RetrieveAnimalsButton.Click += RetrieveAnimalsButton_Click;
            // 
            // DeleteAnimalButton
            // 
            DeleteAnimalButton.Location = new Point(211, 130);
            DeleteAnimalButton.Margin = new Padding(2);
            DeleteAnimalButton.Name = "DeleteAnimalButton";
            DeleteAnimalButton.Size = new Size(174, 27);
            DeleteAnimalButton.TabIndex = 2;
            DeleteAnimalButton.Text = "Delete Animal";
            DeleteAnimalButton.UseVisualStyleBackColor = true;
            DeleteAnimalButton.Click += DeleteAnimalButton_Click_1;
            // 
            // UpdateAnimalButton
            // 
            UpdateAnimalButton.Location = new Point(211, 195);
            UpdateAnimalButton.Margin = new Padding(2);
            UpdateAnimalButton.Name = "UpdateAnimalButton";
            UpdateAnimalButton.Size = new Size(174, 27);
            UpdateAnimalButton.TabIndex = 3;
            UpdateAnimalButton.Text = "Update Animal";
            UpdateAnimalButton.UseVisualStyleBackColor = true;
            UpdateAnimalButton.Click += UpdateAnimalButton_Click;
            // 
            // AddTreatementButton
            // 
            AddTreatementButton.Location = new Point(211, 258);
            AddTreatementButton.Margin = new Padding(2);
            AddTreatementButton.Name = "AddTreatementButton";
            AddTreatementButton.Size = new Size(174, 27);
            AddTreatementButton.TabIndex = 4;
            AddTreatementButton.Text = "Add Treatment ";
            AddTreatementButton.UseVisualStyleBackColor = true;
            AddTreatementButton.Click += AddTreatementButton_Click;
            // 
            // RetrieveMedicalHistoryButton
            // 
            RetrieveMedicalHistoryButton.Location = new Point(211, 315);
            RetrieveMedicalHistoryButton.Margin = new Padding(2);
            RetrieveMedicalHistoryButton.Name = "RetrieveMedicalHistoryButton";
            RetrieveMedicalHistoryButton.Size = new Size(174, 27);
            RetrieveMedicalHistoryButton.TabIndex = 5;
            RetrieveMedicalHistoryButton.Text = "Retrieve Medical History ";
            RetrieveMedicalHistoryButton.UseVisualStyleBackColor = true;
            RetrieveMedicalHistoryButton.Click += RetrieveMedicalHistoryButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 315);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(RetrieveMedicalHistoryButton);
            Controls.Add(AddTreatementButton);
            Controls.Add(UpdateAnimalButton);
            Controls.Add(DeleteAnimalButton);
            Controls.Add(RetrieveAnimalsButton);
            Controls.Add(AddAnimalButton);
            Margin = new Padding(2);
            Name = "StaffForm";
            Text = "StaffForm";
            Load += StaffForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button AddAnimalButton;
        private Button RetrieveAnimalsButton;
        private Button DeleteAnimalButton;
        private Button UpdateAnimalButton;
        private Button AddTreatementButton;
        private Button RetrieveMedicalHistoryButton;
        private Button button1;
    }
}