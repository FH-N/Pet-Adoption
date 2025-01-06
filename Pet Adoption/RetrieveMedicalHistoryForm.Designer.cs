namespace Pet_Adoption
{
    partial class RetrieveMedicalHistoryForm
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
            textBoxAnimalName = new TextBox();
            label1 = new Label();
            buttonSearch = new Button();
            dataGridViewMedicalHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicalHistory).BeginInit();
            SuspendLayout();
            // 
            // textBoxAnimalName
            // 
            textBoxAnimalName.Location = new Point(253, 85);
            textBoxAnimalName.Margin = new Padding(2, 2, 2, 2);
            textBoxAnimalName.Name = "textBoxAnimalName";
            textBoxAnimalName.Size = new Size(229, 27);
            textBoxAnimalName.TabIndex = 0;
            textBoxAnimalName.TextChanged += textBoxAnimalName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Animal Name ";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(253, 174);
            buttonSearch.Margin = new Padding(2, 2, 2, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(90, 27);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewMedicalHistory
            // 
            dataGridViewMedicalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicalHistory.Location = new Point(3, 242);
            dataGridViewMedicalHistory.Margin = new Padding(2, 2, 2, 2);
            dataGridViewMedicalHistory.Name = "dataGridViewMedicalHistory";
            dataGridViewMedicalHistory.RowHeadersWidth = 62;
            dataGridViewMedicalHistory.Size = new Size(634, 118);
            dataGridViewMedicalHistory.TabIndex = 3;
            // 
            // RetrieveMedicalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(dataGridViewMedicalHistory);
            Controls.Add(buttonSearch);
            Controls.Add(label1);
            Controls.Add(textBoxAnimalName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RetrieveMedicalHistoryForm";
            Text = "RetrieveMedicalHistoryForm";
            Load += RetrieveMedicalHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicalHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAnimalName;
        private Label label1;
        private Button buttonSearch;
        private DataGridView dataGridViewMedicalHistory;
    }
}