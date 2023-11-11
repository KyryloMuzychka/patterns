namespace Lab5_1
{
    partial class ShopForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.listProducts = new System.Windows.Forms.Label();
            this.productsListView = new System.Windows.Forms.ListView();
            this.payButton = new System.Windows.Forms.Button();
            this.totalPriceAmountLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(304, 45);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(121, 22);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(237, 51);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(61, 16);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(85, 110);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 24);
            this.productComboBox.TabIndex = 4;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(26, 118);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(53, 16);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Product";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(240, 112);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(74, 22);
            this.amountNumericUpDown.TabIndex = 6;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.amountNumericUpDown_ValueChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(334, 118);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 16);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price:";
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Location = new System.Drawing.Point(381, 118);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(14, 16);
            this.priceAmountLabel.TabIndex = 8;
            this.priceAmountLabel.Text = "0";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(470, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 24);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listProducts
            // 
            this.listProducts.AutoSize = true;
            this.listProducts.Location = new System.Drawing.Point(26, 158);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(97, 16);
            this.listProducts.TabIndex = 10;
            this.listProducts.Text = "List of Products";
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(29, 177);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(983, 209);
            this.productsListView.TabIndex = 11;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(937, 399);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 32);
            this.payButton.TabIndex = 12;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // totalPriceAmountLabel
            // 
            this.totalPriceAmountLabel.AutoSize = true;
            this.totalPriceAmountLabel.Location = new System.Drawing.Point(73, 399);
            this.totalPriceAmountLabel.Name = "totalPriceAmountLabel";
            this.totalPriceAmountLabel.Size = new System.Drawing.Size(14, 16);
            this.totalPriceAmountLabel.TabIndex = 14;
            this.totalPriceAmountLabel.Text = "0";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(26, 399);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(41, 16);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.Text = "Total:";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.totalPriceAmountLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceAmountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ShopForm";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceAmountLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label listProducts;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label totalPriceAmountLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

