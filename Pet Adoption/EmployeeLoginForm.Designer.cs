namespace Pet_Adoption
{
    partial class EmployeeLoginForm
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
            EmployeeLogInButton = new Button();
            EmployeeLogInLabel = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // EmployeeLogInButton
            // 
            EmployeeLogInButton.Location = new Point(536, 157);
            EmployeeLogInButton.Name = "EmployeeLogInButton";
            EmployeeLogInButton.Size = new Size(112, 34);
            EmployeeLogInButton.TabIndex = 0;
            EmployeeLogInButton.Text = "button1";
            EmployeeLogInButton.UseVisualStyleBackColor = true;
            EmployeeLogInButton.Click += EmployeeLogInButton_Click;
            // 
            // EmployeeLogInLabel
            // 
            EmployeeLogInLabel.AutoSize = true;
            EmployeeLogInLabel.Location = new Point(35, 121);
            EmployeeLogInLabel.Name = "EmployeeLogInLabel";
            EmployeeLogInLabel.Size = new Size(52, 25);
            EmployeeLogInLabel.TabIndex = 1;
            EmployeeLogInLabel.Text = "login";
            EmployeeLogInLabel.Click += EmployeeLogInLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 31);
            textBox1.TabIndex = 2;
            // 
            // EmployeeLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(EmployeeLogInLabel);
            Controls.Add(EmployeeLogInButton);
            Name = "EmployeeLoginForm";
            Text = "EmployeeLoginForm";
            Load += EmployeeLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmployeeLogInButton;
        private Label EmployeeLogInLabel;
        private TextBox textBox1;
    }
}