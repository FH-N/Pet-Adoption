namespace Pet_Adoption
{
    partial class StaffFollowUp
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
            addButton = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(251, 107);
            addButton.Name = "addButton";
            addButton.Size = new Size(254, 78);
            addButton.TabIndex = 0;
            addButton.Text = "Add Follow Up";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 237);
            button2.Name = "button2";
            button2.Size = new Size(254, 78);
            button2.TabIndex = 1;
            button2.Text = "Retrieve Follow Ups";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffFollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(addButton);
            Name = "StaffFollowUp";
            Text = "Form1";
            Load += StaffFollowUp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button button2;
        private Button button1;
    }
}