namespace Pet_Adoption
{
    partial class StahhHomePage
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
            adopterButton = new Button();
            animalButton = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // adopterButton
            // 
            adopterButton.Location = new Point(263, 94);
            adopterButton.Name = "adopterButton";
            adopterButton.Size = new Size(245, 76);
            adopterButton.TabIndex = 0;
            adopterButton.Text = "Adopter";
            adopterButton.UseVisualStyleBackColor = true;
            adopterButton.Click += adopterButton_Click;
            // 
            // animalButton
            // 
            animalButton.Location = new Point(263, 260);
            animalButton.Name = "animalButton";
            animalButton.Size = new Size(245, 76);
            animalButton.TabIndex = 1;
            animalButton.Text = "Animal";
            animalButton.UseVisualStyleBackColor = true;
            animalButton.Click += animalButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 49);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 2;
            label1.Text = "Operations Related to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 207);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 3;
            label2.Text = "Or";
            // 
            // button1
            // 
            button1.Location = new Point(29, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StahhHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(animalButton);
            Controls.Add(adopterButton);
            Name = "StahhHomePage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adopterButton;
        private Button animalButton;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}