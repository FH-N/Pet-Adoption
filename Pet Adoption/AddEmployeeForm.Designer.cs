using System.Xml.Linq;

namespace Pet_Adoption
{
    partial class AddEmployeeForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtSalary = new TextBox();
            button1 = new Button();
            lblEmailError = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 65);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 27);
            txtName.TabIndex = 0;
            txtName.Text = "txtName";
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 122);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "txtEmail";
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(70, 190);
            txtSalary.Margin = new Padding(2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(321, 27);
            txtSalary.TabIndex = 2;
            txtSalary.Text = "salary ";
            // 
            // button1
            // 
            button1.Location = new Point(250, 289);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 3;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Firebrick;
            lblEmailError.Location = new Point(486, 108);
            lblEmailError.Margin = new Padding(2, 0, 2, 0);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(95, 20);
            lblEmailError.TabIndex = 4;
            lblEmailError.Text = "lblEmailError";
            lblEmailError.Visible = false;
            lblEmailError.Click += label1_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblEmailError);
            Controls.Add(button1);
            Controls.Add(txtSalary);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Margin = new Padding(2);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtSalary;
        private Button button1;
        private Label lblEmailError;
    }
}