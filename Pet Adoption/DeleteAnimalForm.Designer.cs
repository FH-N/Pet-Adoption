namespace Pet_Adoption
{
    partial class DeleteAnimalForm
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
            textBoxShelterName = new TextBox();
            label2 = new Label();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // textBoxAnimalName
            // 
            textBoxAnimalName.Location = new Point(210, 77);
            textBoxAnimalName.Margin = new Padding(2);
            textBoxAnimalName.Name = "textBoxAnimalName";
            textBoxAnimalName.Size = new Size(270, 27);
            textBoxAnimalName.TabIndex = 1;
            textBoxAnimalName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Animal Name";
            // 
            // textBoxShelterName
            // 
            textBoxShelterName.Location = new Point(210, 143);
            textBoxShelterName.Margin = new Padding(2);
            textBoxShelterName.Name = "textBoxShelterName";
            textBoxShelterName.Size = new Size(270, 27);
            textBoxShelterName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 148);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Shelter Name";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(250, 237);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 27);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button1_Click;
            // 
            // DeleteAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(textBoxShelterName);
            Controls.Add(label1);
            Controls.Add(textBoxAnimalName);
            Margin = new Padding(2);
            Name = "DeleteAnimalForm";
            Text = "DeleteAnimalForm";
            Load += DeleteAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAnimalName;
        private Label label1;
        private TextBox textBoxShelterName;
        private Label label2;
        private Button buttonDelete;
    }
}