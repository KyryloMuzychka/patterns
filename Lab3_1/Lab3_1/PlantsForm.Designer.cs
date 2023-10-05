namespace Lab3_1
{
    partial class PlantsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            countryComboBox = new ComboBox();
            plantComboBox = new ComboBox();
            descriptionTextBox = new TextBox();
            picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(37, 49);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(352, 40);
            countryComboBox.TabIndex = 0;
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            // 
            // plantComboBox
            // 
            plantComboBox.FormattingEnabled = true;
            plantComboBox.Location = new Point(37, 116);
            plantComboBox.Name = "plantComboBox";
            plantComboBox.Size = new Size(352, 40);
            plantComboBox.TabIndex = 1;
            plantComboBox.SelectedIndexChanged += plantComboBox_SelectedIndexChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(37, 193);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(705, 517);
            descriptionTextBox.TabIndex = 2;
            // 
            // picture
            // 
            picture.Location = new Point(785, 30);
            picture.Name = "picture";
            picture.Size = new Size(423, 680);
            picture.TabIndex = 3;
            picture.TabStop = false;
            // 
            // PlantsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 750);
            Controls.Add(picture);
            Controls.Add(descriptionTextBox);
            Controls.Add(plantComboBox);
            Controls.Add(countryComboBox);
            MaximumSize = new Size(1278, 821);
            MinimumSize = new Size(1278, 821);
            Name = "PlantsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plants";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox countryComboBox;
        private ComboBox plantComboBox;
        private TextBox descriptionTextBox;
        private PictureBox picture;
    }
}