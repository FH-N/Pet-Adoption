namespace Pet_Adoption
{
    partial class UpdateEmployeeForm
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
            textBoxEmployeeID = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Email = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new TextBox();
            textBoxSalary = new TextBox();
            textBoxShelterID = new TextBox();
            buttonRetrieve = new Button();
            buttonUpdate = new Button();
            label3 = new Label();
            textBoxSupervisorID = new TextBox();
            SuspendLayout();
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(240, 86);
            textBoxEmployeeID.Margin = new Padding(2);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(242, 27);
            textBoxEmployeeID.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(230, 251);
            textBoxName.Margin = new Padding(2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 27);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 250);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(127, 303);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 345);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 389);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 6;
            label5.Text = "Shelter ID";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(230, 298);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(246, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(230, 345);
            textBoxSalary.Margin = new Padding(2);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(246, 27);
            textBoxSalary.TabIndex = 8;
            // 
            // textBoxShelterID
            // 
            textBoxShelterID.Location = new Point(230, 389);
            textBoxShelterID.Margin = new Padding(2);
            textBoxShelterID.Name = "textBoxShelterID";
            textBoxShelterID.Size = new Size(246, 27);
            textBoxShelterID.TabIndex = 9;
            // 
            // buttonRetrieve
            // 
            buttonRetrieve.Location = new Point(297, 147);
            buttonRetrieve.Margin = new Padding(2);
            buttonRetrieve.Name = "buttonRetrieve";
            buttonRetrieve.Size = new Size(90, 27);
            buttonRetrieve.TabIndex = 10;
            buttonRetrieve.Text = "Retrieve";
            buttonRetrieve.UseVisualStyleBackColor = true;
            buttonRetrieve.Click += buttonRetrieve_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(286, 434);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(101, 31);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 208);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 12;
            label3.Text = "Supervisor ID";
            // 
            // textBoxSupervisorID
            // 
            textBoxSupervisorID.Location = new Point(230, 208);
            textBoxSupervisorID.Name = "textBoxSupervisorID";
            textBoxSupervisorID.Size = new Size(246, 27);
            textBoxSupervisorID.TabIndex = 13;
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 490);
            Controls.Add(textBoxSupervisorID);
            Controls.Add(label3);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRetrieve);
            Controls.Add(textBoxShelterID);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmployeeID);
            Margin = new Padding(2);
            Name = "UpdateEmployeeForm";
            Text = "UpdateEmployeeForm";
            Load += UpdateEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmployeeID;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label Email;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxSalary;
        private TextBox textBoxShelterID;
        private Button buttonRetrieve;
        private Button buttonUpdate;
        private Label label3;
        private TextBox textBoxSupervisorID;
    }
}