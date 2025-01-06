namespace Pet_Adoption
{
    partial class AdopterForm
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
            nameTextBox = new TextBox();
            phoneNumTextBox = new TextBox();
            addressTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            addressLabel = new Label();
            signUpButton = new Button();
            label1 = new Label();
            label2 = new Label();
            logInEmailtextBox = new TextBox();
            LogInButton = new Button();
            label3 = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(164, 61);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 0;
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Location = new Point(213, 168);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(125, 27);
            phoneNumTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(182, 228);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(125, 27);
            addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(164, 116);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(72, 64);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.Click += label1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(71, 119);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(71, 168);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 6;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(71, 231);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address";
            addressLabel.Click += addressLabel_Click;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(164, 302);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 8;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 168);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 9;
            label1.Text = "OR";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 191);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // logInEmailtextBox
            // 
            logInEmailtextBox.Location = new Point(503, 228);
            logInEmailtextBox.Name = "logInEmailtextBox";
            logInEmailtextBox.Size = new Size(183, 27);
            logInEmailtextBox.TabIndex = 11;
            logInEmailtextBox.TextChanged += logInEmailtextBox_TextChanged;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(521, 293);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(94, 29);
            LogInButton.TabIndex = 12;
            LogInButton.Text = "Sign In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 142);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "Log In";
            // 
            // backButton
            // 
            backButton.Location = new Point(27, 389);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 14;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // AdopterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(LogInButton);
            Controls.Add(logInEmailtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUpButton);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(emailTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(phoneNumTextBox);
            Controls.Add(nameTextBox);
            Name = "AdopterForm";
            Text = "Form2";
            Load += AdopterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox phoneNumTextBox;
        private TextBox addressTextBox;
        private TextBox emailTextBox;
        private Label nameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private Button signUpButton;
        private Label label1;
        private Label label2;
        private TextBox logInEmailtextBox;
        private Button LogInButton;
        private Label label3;
        private Button backButton;
    }
}