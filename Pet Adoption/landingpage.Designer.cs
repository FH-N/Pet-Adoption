namespace Pet_Adoption
{
    partial class LandingPage
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
            employeebutton = new Button();
            adopter = new Button();
            AboutUsButton = new Button();
            SuspendLayout();
            // 
            // employeebutton
            // 
            employeebutton.Location = new Point(280, 79);
            employeebutton.Name = "employeebutton";
            employeebutton.Size = new Size(168, 78);
            employeebutton.TabIndex = 0;
            employeebutton.Text = "Shelter Employee";
            employeebutton.UseVisualStyleBackColor = true;
            employeebutton.Click += employeebutton_Click;
            // 
            // adopter
            // 
            adopter.Location = new Point(280, 182);
            adopter.Name = "adopter";
            adopter.Size = new Size(168, 78);
            adopter.TabIndex = 1;
            adopter.Text = "Adopter";
            adopter.UseVisualStyleBackColor = true;
            adopter.Click += adopter_Click_1;
            // 
            // AboutUsButton
            // 
            AboutUsButton.Location = new Point(280, 291);
            AboutUsButton.Name = "AboutUsButton";
            AboutUsButton.Size = new Size(168, 78);
            AboutUsButton.TabIndex = 2;
            AboutUsButton.Text = "About Us";
            AboutUsButton.UseVisualStyleBackColor = true;
            AboutUsButton.Click += AboutUsButton_Click;
            // 
            // landingpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AboutUsButton);
            Controls.Add(adopter);
            Controls.Add(employeebutton);
            Name = "landingpage";
            Text = "Form2";
            Load += landingpage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button employeebutton;
        private Button adopter;
        private Button AboutUsButton;
    }
}