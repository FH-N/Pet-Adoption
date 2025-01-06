namespace Pet_Adoption
{
    partial class AdopterHomePage
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
            searchButton = new Button();
            statusButton = new Button();
            followUpButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(261, 49);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(267, 72);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search Animals";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // statusButton
            // 
            statusButton.Location = new Point(261, 166);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(267, 72);
            statusButton.TabIndex = 1;
            statusButton.Text = "Check Adoption Status";
            statusButton.UseVisualStyleBackColor = true;
            statusButton.Click += statusButton_Click;
            // 
            // followUpButton
            // 
            followUpButton.Location = new Point(261, 280);
            followUpButton.Name = "followUpButton";
            followUpButton.Size = new Size(267, 72);
            followUpButton.TabIndex = 2;
            followUpButton.Text = "Adoption FollowUp Info";
            followUpButton.UseVisualStyleBackColor = true;
            followUpButton.Click += followUpButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AdopterHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(followUpButton);
            Controls.Add(statusButton);
            Controls.Add(searchButton);
            Name = "AdopterHomePage";
            Text = "Form2";
            Load += AdopterHomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button searchButton;
        private Button statusButton;
        private Button followUpButton;
        private Button button1;
    }
}