namespace Lab7_2
{
    partial class WeatherForm
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
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.temperatureEdit = new System.Windows.Forms.TextBox();
            this.humidityEdit = new System.Windows.Forms.TextBox();
            this.pressureEdit = new System.Windows.Forms.TextBox();
            this.SetDataButton = new System.Windows.Forms.Button();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(20, 20);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(146, 25);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temperature = ";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(20, 81);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(109, 25);
            this.humidityLabel.TabIndex = 1;
            this.humidityLabel.Text = "Humidity = ";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(20, 138);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(112, 25);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "Pressure = ";
            // 
            // temperatureEdit
            // 
            this.temperatureEdit.Location = new System.Drawing.Point(195, 9);
            this.temperatureEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.temperatureEdit.Name = "temperatureEdit";
            this.temperatureEdit.Size = new System.Drawing.Size(148, 30);
            this.temperatureEdit.TabIndex = 3;
            // 
            // humidityEdit
            // 
            this.humidityEdit.Location = new System.Drawing.Point(195, 77);
            this.humidityEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.humidityEdit.Name = "humidityEdit";
            this.humidityEdit.Size = new System.Drawing.Size(148, 30);
            this.humidityEdit.TabIndex = 4;
            // 
            // pressureEdit
            // 
            this.pressureEdit.Location = new System.Drawing.Point(195, 133);
            this.pressureEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pressureEdit.Name = "pressureEdit";
            this.pressureEdit.Size = new System.Drawing.Size(148, 30);
            this.pressureEdit.TabIndex = 5;
            // 
            // SetDataButton
            // 
            this.SetDataButton.Location = new System.Drawing.Point(24, 216);
            this.SetDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDataButton.Name = "SetDataButton";
            this.SetDataButton.Size = new System.Drawing.Size(321, 47);
            this.SetDataButton.TabIndex = 6;
            this.SetDataButton.Text = "Set Data";
            this.SetDataButton.UseVisualStyleBackColor = true;
            this.SetDataButton.Click += new System.EventHandler(this.SetDataButton_Click);
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.ItemHeight = 25;
            this.ListBoxResult.Location = new System.Drawing.Point(365, 9);
            this.ListBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.Size = new System.Drawing.Size(496, 254);
            this.ListBoxResult.TabIndex = 7;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 291);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.SetDataButton);
            this.Controls.Add(this.pressureEdit);
            this.Controls.Add(this.humidityEdit);
            this.Controls.Add(this.temperatureEdit);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.TextBox temperatureEdit;
        private System.Windows.Forms.TextBox humidityEdit;
        private System.Windows.Forms.TextBox pressureEdit;
        private System.Windows.Forms.Button SetDataButton;
        private System.Windows.Forms.ListBox ListBoxResult;
    }
}

