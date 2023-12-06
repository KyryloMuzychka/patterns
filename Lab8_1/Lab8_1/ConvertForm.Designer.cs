namespace Lab8_1
{
    partial class ConvertForm
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.QualityEdit = new System.Windows.Forms.TextBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(36, 93);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(288, 36);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // QualityEdit
            // 
            this.QualityEdit.Location = new System.Drawing.Point(125, 35);
            this.QualityEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QualityEdit.Name = "QualityEdit";
            this.QualityEdit.Size = new System.Drawing.Size(199, 30);
            this.QualityEdit.TabIndex = 1;
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(31, 40);
            this.QualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(95, 25);
            this.QualityLabel.TabIndex = 2;
            this.QualityLabel.Text = "Quality = ";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(31, 157);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 25);
            this.InfoLabel.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(36, 239);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(288, 23);
            this.progressBar.TabIndex = 4;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 285);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityEdit);
            this.Controls.Add(this.ConvertButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConvertForm";
            this.Text = "Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox QualityEdit;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

