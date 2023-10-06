namespace Lab3_2
{
    partial class SoundsForm
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
            habitatComboBox = new ComboBox();
            animalComboBox = new ComboBox();
            soundLabel = new Label();
            SuspendLayout();
            // 
            // habitatComboBox
            // 
            habitatComboBox.Location = new Point(57, 48);
            habitatComboBox.Name = "habitatComboBox";
            habitatComboBox.Size = new Size(400, 40);
            habitatComboBox.TabIndex = 4;
            habitatComboBox.SelectedIndexChanged += habitatComboBox_SelectedIndexChanged;
            // 
            // animalComboBox
            // 
            animalComboBox.Location = new Point(57, 121);
            animalComboBox.Name = "animalComboBox";
            animalComboBox.Size = new Size(400, 40);
            animalComboBox.TabIndex = 3;
            animalComboBox.SelectedIndexChanged += animalComboBox_SelectedIndexChanged;
            // 
            // soundLabel
            // 
            soundLabel.AutoSize = true;
            soundLabel.Location = new Point(57, 191);
            soundLabel.Name = "soundLabel";
            soundLabel.Size = new Size(0, 32);
            soundLabel.TabIndex = 2;
            // 
            // SoundsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 274);
            Controls.Add(soundLabel);
            Controls.Add(animalComboBox);
            Controls.Add(habitatComboBox);
            Name = "SoundsForm";
            Text = "Animals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox habitatComboBox;
        private ComboBox animalComboBox;
        private Label soundLabel;
    }
}