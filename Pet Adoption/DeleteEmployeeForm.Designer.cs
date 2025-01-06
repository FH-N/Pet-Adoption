namespace Pet_Adoption
{
    partial class DeleteEmployeeForm
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
            buttonDelete = new Button();
            labelEmployeeID = new Label();
            SuspendLayout();
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(208, 118);
            textBoxEmployeeID.Margin = new Padding(2, 2, 2, 2);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(290, 27);
            textBoxEmployeeID.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(208, 197);
            buttonDelete.Margin = new Padding(2, 2, 2, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 26);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelEmployeeID
            // 
            labelEmployeeID.AutoSize = true;
            labelEmployeeID.Location = new Point(57, 118);
            labelEmployeeID.Margin = new Padding(2, 0, 2, 0);
            labelEmployeeID.Name = "labelEmployeeID";
            labelEmployeeID.Size = new Size(94, 20);
            labelEmployeeID.TabIndex = 2;
            labelEmployeeID.Text = "Employee ID";
            // 
            // DeleteEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(labelEmployeeID);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxEmployeeID);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DeleteEmployeeForm";
            Text = "DeleteEmployeeForm";
            Load += DeleteEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmployeeID;
        private Button buttonDelete;
        private Label labelEmployeeID;
    }
}