namespace Pet_Adoption
{
    partial class RetrieveAnimalsForm
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
            dataGridViewAnimals = new DataGridView();
            textBoxSearch = new TextBox();
            label1 = new Label();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnimals
            // 
            dataGridViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimals.Location = new Point(2, 213);
            dataGridViewAnimals.Margin = new Padding(2);
            dataGridViewAnimals.Name = "dataGridViewAnimals";
            dataGridViewAnimals.RowHeadersWidth = 62;
            dataGridViewAnimals.Size = new Size(638, 150);
            dataGridViewAnimals.TabIndex = 0;
            dataGridViewAnimals.CellContentClick += dataGridViewAnimals_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(220, 82);
            textBoxSearch.Margin = new Padding(2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(223, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Animal name";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(214, 165);
            buttonSearch.Margin = new Padding(2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(176, 32);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // RetrieveAnimalsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(buttonSearch);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewAnimals);
            Margin = new Padding(2);
            Name = "RetrieveAnimalsForm";
            Text = "RetrieveAnimalsForm";
            Load += RetrieveAnimalsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAnimals;
        private TextBox textBoxSearch;
        private Label label1;
        private Button buttonSearch;
    }
}