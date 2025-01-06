namespace Pet_Adoption
{
    partial class AddFollowUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            employeeIDTextBox = new TextBox();
            adopterIDTextBox = new TextBox();
            followUpDatePicker = new DateTimePicker();
            notesTextBox = new TextBox();
            addButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 62);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "AdopterID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 186);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Follow Up Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 253);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Notes";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(199, 62);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.Size = new Size(125, 27);
            employeeIDTextBox.TabIndex = 4;
            // 
            // adopterIDTextBox
            // 
            adopterIDTextBox.Location = new Point(199, 122);
            adopterIDTextBox.Name = "adopterIDTextBox";
            adopterIDTextBox.Size = new Size(125, 27);
            adopterIDTextBox.TabIndex = 5;
            // 
            // followUpDatePicker
            // 
            followUpDatePicker.Location = new Point(209, 186);
            followUpDatePicker.Name = "followUpDatePicker";
            followUpDatePicker.Size = new Size(250, 27);
            followUpDatePicker.TabIndex = 6;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(169, 253);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(526, 27);
            notesTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(169, 336);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddFollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(notesTextBox);
            Controls.Add(followUpDatePicker);
            Controls.Add(adopterIDTextBox);
            Controls.Add(employeeIDTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFollowUp";
            Text = "Form1";
            Load += AddFollowUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox employeeIDTextBox;
        private TextBox adopterIDTextBox;
        private DateTimePicker followUpDatePicker;
        private TextBox notesTextBox;
        private Button addButton;
        private Button button1;
    }
}