namespace Pet_Adoption
{
    partial class RetrieveEmployeeForm
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
            Refresh = new Button();
            txtSearchName = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Location = new Point(384, 175);
            Refresh.Margin = new Padding(2);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(90, 27);
            Refresh.TabIndex = 1;
            Refresh.Text = "Submit";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button1_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(318, 121);
            txtSearchName.Margin = new Padding(2);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(226, 27);
            txtSearchName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 2);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(244, 348);
            dataGridView1.TabIndex = 3;
            // 
            // RetrieveEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchName);
            Controls.Add(Refresh);
            Margin = new Padding(2);
            Name = "RetrieveEmployeeForm";
            Text = "RetrieveEmployeeForm";
            Load += RetrieveEmployeeForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Refresh;
        private TextBox txtSearchName;
        private DataGridView dataGridView1;
    }
}