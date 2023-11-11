namespace Lab5_2
{
    partial class CarEngineForm
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
            this.temperatureBox = new System.Windows.Forms.TextBox();
            this.airBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.airLabel = new System.Windows.Forms.Label();
            this.startEngineButton = new System.Windows.Forms.Button();
            this.stopEngineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temperatureBox
            // 
            this.temperatureBox.Location = new System.Drawing.Point(248, 56);
            this.temperatureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.temperatureBox.Name = "temperatureBox";
            this.temperatureBox.Size = new System.Drawing.Size(172, 34);
            this.temperatureBox.TabIndex = 0;
            // 
            // airBox
            // 
            this.airBox.Location = new System.Drawing.Point(248, 137);
            this.airBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.airBox.Name = "airBox";
            this.airBox.Size = new System.Drawing.Size(172, 34);
            this.airBox.TabIndex = 1;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(76, 61);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(153, 29);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Temperature";
            // 
            // airLabel
            // 
            this.airLabel.AutoSize = true;
            this.airLabel.Location = new System.Drawing.Point(54, 142);
            this.airLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.airLabel.Name = "airLabel";
            this.airLabel.Size = new System.Drawing.Size(175, 29);
            this.airLabel.TabIndex = 3;
            this.airLabel.Text = "Air Flow (m3/s)";
            // 
            // startEngineButton
            // 
            this.startEngineButton.Location = new System.Drawing.Point(59, 220);
            this.startEngineButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.startEngineButton.Name = "startEngineButton";
            this.startEngineButton.Size = new System.Drawing.Size(361, 41);
            this.startEngineButton.TabIndex = 4;
            this.startEngineButton.Text = "Start Engine";
            this.startEngineButton.UseVisualStyleBackColor = true;
            this.startEngineButton.Click += new System.EventHandler(this.startEngineButton_Click);
            // 
            // stopEngineButton
            // 
            this.stopEngineButton.Enabled = false;
            this.stopEngineButton.Location = new System.Drawing.Point(59, 271);
            this.stopEngineButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stopEngineButton.Name = "stopEngineButton";
            this.stopEngineButton.Size = new System.Drawing.Size(361, 41);
            this.stopEngineButton.TabIndex = 5;
            this.stopEngineButton.Text = "Stop Engine";
            this.stopEngineButton.UseVisualStyleBackColor = true;
            this.stopEngineButton.Click += new System.EventHandler(this.stopEngineButton_Click);
            // 
            // CarEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 352);
            this.Controls.Add(this.stopEngineButton);
            this.Controls.Add(this.startEngineButton);
            this.Controls.Add(this.airLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.airBox);
            this.Controls.Add(this.temperatureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CarEngineForm";
            this.Text = "Start Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temperatureBox;
        private System.Windows.Forms.TextBox airBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label airLabel;
        private System.Windows.Forms.Button startEngineButton;
        private System.Windows.Forms.Button stopEngineButton;
    }
}

