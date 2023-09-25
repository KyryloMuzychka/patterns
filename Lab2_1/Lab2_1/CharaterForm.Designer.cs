namespace Lab2_1
{
    partial class CharaterForm
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
            nameBox = new ComboBox();
            nameLabel = new Label();
            weaponsLabel = new Label();
            powerLabel = new Label();
            nameText = new TextBox();
            powerText = new TextBox();
            weaponsText = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.FormattingEnabled = true;
            nameBox.Location = new Point(44, 110);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(242, 40);
            nameBox.TabIndex = 0;
            nameBox.Text = "Choose Character";
            nameBox.SelectedIndexChanged += nameBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(382, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // weaponsLabel
            // 
            weaponsLabel.AutoSize = true;
            weaponsLabel.Location = new Point(382, 295);
            weaponsLabel.Name = "weaponsLabel";
            weaponsLabel.Size = new Size(112, 32);
            weaponsLabel.TabIndex = 2;
            weaponsLabel.Text = "Weapons";
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Location = new Point(382, 174);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(78, 32);
            powerLabel.TabIndex = 3;
            powerLabel.Text = "Power";
            // 
            // nameText
            // 
            nameText.Location = new Point(382, 110);
            nameText.Name = "nameText";
            nameText.Size = new Size(709, 39);
            nameText.TabIndex = 4;
            // 
            // powerText
            // 
            powerText.Location = new Point(382, 220);
            powerText.Name = "powerText";
            powerText.Size = new Size(709, 39);
            powerText.TabIndex = 5;
            // 
            // weaponsText
            // 
            weaponsText.Location = new Point(382, 343);
            weaponsText.Multiline = true;
            weaponsText.Name = "weaponsText";
            weaponsText.Size = new Size(709, 145);
            weaponsText.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 59);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 7;
            label1.Text = "Character";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 544);
            Controls.Add(label1);
            Controls.Add(weaponsText);
            Controls.Add(powerText);
            Controls.Add(nameText);
            Controls.Add(powerLabel);
            Controls.Add(weaponsLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Lab2_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nameBox;
        private Label nameLabel;
        private Label weaponsLabel;
        private Label powerLabel;
        private TextBox nameText;
        private TextBox powerText;
        private TextBox weaponsText;
        private Label label1;
    }
}