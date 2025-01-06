namespace Pet_Adoption
{
    partial class SearchAnimals
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
            searchBox = new TextBox();
            searchButton = new Button();
            flowLayoutPanelResults = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(425, 47);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(326, 27);
            searchBox.TabIndex = 0;
            searchBox.Text = "search by breed or species";
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(777, 47);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // flowLayoutPanelResults
            // 
            flowLayoutPanelResults.AutoScroll = true;
            flowLayoutPanelResults.Location = new Point(56, 106);
            flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            flowLayoutPanelResults.Size = new Size(1131, 505);
            flowLayoutPanelResults.TabIndex = 2;
            flowLayoutPanelResults.Paint += flowLayoutPanelResults_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(13, 585);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchAnimals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 623);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanelResults);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Name = "SearchAnimals";
            Text = "Form2";
            Load += SearchAnimals_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button searchButton;
        private FlowLayoutPanel flowLayoutPanelResults;
        private Button button1;
    }
}