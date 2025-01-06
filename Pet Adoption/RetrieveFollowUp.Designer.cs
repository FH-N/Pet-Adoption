namespace Pet_Adoption
{
    partial class RetrieveFollowUp
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
            resultsPanel = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(87, 42);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(239, 27);
            searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(358, 42);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultsPanel
            // 
            resultsPanel.AutoScroll = true;
            resultsPanel.Location = new Point(26, 97);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(753, 341);
            resultsPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RetrieveFollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(resultsPanel);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Name = "RetrieveFollowUp";
            Text = "Form1";
            Load += RetrieveFollowUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Button searchButton;
        private FlowLayoutPanel resultsPanel;
        private Button button1;
    }
}