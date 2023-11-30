namespace Lab7_1
{
    partial class MainForm
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
            this.UpdatePricesButton = new System.Windows.Forms.Button();
            this.NewPriceTextBox = new System.Windows.Forms.TextBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.CurrentPriceProductLabel = new System.Windows.Forms.Label();
            this.NewPriceLabel = new System.Windows.Forms.Label();
            this.priceOfProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdatePricesButton
            // 
            this.UpdatePricesButton.Location = new System.Drawing.Point(42, 225);
            this.UpdatePricesButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UpdatePricesButton.Name = "UpdatePricesButton";
            this.UpdatePricesButton.Size = new System.Drawing.Size(266, 65);
            this.UpdatePricesButton.TabIndex = 0;
            this.UpdatePricesButton.Text = "Set new price";
            this.UpdatePricesButton.UseVisualStyleBackColor = true;
            this.UpdatePricesButton.Click += new System.EventHandler(this.UpdatePricesButton_Click);
            // 
            // NewPriceTextBox
            // 
            this.NewPriceTextBox.Location = new System.Drawing.Point(42, 169);
            this.NewPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NewPriceTextBox.Name = "NewPriceTextBox";
            this.NewPriceTextBox.Size = new System.Drawing.Size(266, 34);
            this.NewPriceTextBox.TabIndex = 1;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 29;
            this.listBoxResults.Location = new System.Drawing.Point(350, 54);
            this.listBoxResults.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(354, 265);
            this.listBoxResults.TabIndex = 2;
            // 
            // CurrentPriceProductLabel
            // 
            this.CurrentPriceProductLabel.AutoSize = true;
            this.CurrentPriceProductLabel.Location = new System.Drawing.Point(37, 54);
            this.CurrentPriceProductLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CurrentPriceProductLabel.Name = "CurrentPriceProductLabel";
            this.CurrentPriceProductLabel.Size = new System.Drawing.Size(271, 29);
            this.CurrentPriceProductLabel.TabIndex = 3;
            this.CurrentPriceProductLabel.Text = "Current price of product:";
            // 
            // NewPriceLabel
            // 
            this.NewPriceLabel.AutoSize = true;
            this.NewPriceLabel.Location = new System.Drawing.Point(37, 136);
            this.NewPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NewPriceLabel.Name = "NewPriceLabel";
            this.NewPriceLabel.Size = new System.Drawing.Size(129, 29);
            this.NewPriceLabel.TabIndex = 4;
            this.NewPriceLabel.Text = "New price:";
            // 
            // priceOfProduct
            // 
            this.priceOfProduct.AutoSize = true;
            this.priceOfProduct.Location = new System.Drawing.Point(37, 93);
            this.priceOfProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.priceOfProduct.Name = "priceOfProduct";
            this.priceOfProduct.Size = new System.Drawing.Size(52, 29);
            this.priceOfProduct.TabIndex = 5;
            this.priceOfProduct.Text = "300";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 324);
            this.Controls.Add(this.priceOfProduct);
            this.Controls.Add(this.NewPriceLabel);
            this.Controls.Add(this.CurrentPriceProductLabel);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.NewPriceTextBox);
            this.Controls.Add(this.UpdatePricesButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdatePricesButton;
        private System.Windows.Forms.TextBox NewPriceTextBox;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label CurrentPriceProductLabel;
        private System.Windows.Forms.Label NewPriceLabel;
        private System.Windows.Forms.Label priceOfProduct;
    }
}

