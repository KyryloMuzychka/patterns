namespace Lab8_2
{
    partial class PizzaForm
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
            this.OrderPizzaButton = new System.Windows.Forms.Button();
            this.ChoosePizzaComboBox = new System.Windows.Forms.ComboBox();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderPizzaButton
            // 
            this.OrderPizzaButton.Location = new System.Drawing.Point(58, 142);
            this.OrderPizzaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderPizzaButton.Name = "OrderPizzaButton";
            this.OrderPizzaButton.Size = new System.Drawing.Size(202, 56);
            this.OrderPizzaButton.TabIndex = 0;
            this.OrderPizzaButton.Text = "Order Pizza";
            this.OrderPizzaButton.UseVisualStyleBackColor = true;
            this.OrderPizzaButton.Click += new System.EventHandler(this.OrderPizzaButton_Click);
            // 
            // ChoosePizzaComboBox
            // 
            this.ChoosePizzaComboBox.FormattingEnabled = true;
            this.ChoosePizzaComboBox.Location = new System.Drawing.Point(58, 87);
            this.ChoosePizzaComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChoosePizzaComboBox.Name = "ChoosePizzaComboBox";
            this.ChoosePizzaComboBox.Size = new System.Drawing.Size(202, 33);
            this.ChoosePizzaComboBox.TabIndex = 1;
            // 
            // OrderListBox
            // 
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 25;
            this.OrderListBox.Location = new System.Drawing.Point(285, 46);
            this.OrderListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(564, 304);
            this.OrderListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Pizza";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(58, 220);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(202, 56);
            this.NewOrderButton.TabIndex = 4;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(53, 325);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 378);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.ChoosePizzaComboBox);
            this.Controls.Add(this.OrderPizzaButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PizzaForm";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderPizzaButton;
        private System.Windows.Forms.ComboBox ChoosePizzaComboBox;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Label TotalLabel;
    }
}

