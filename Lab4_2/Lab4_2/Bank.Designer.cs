namespace Lab4_2
{
    partial class Bank
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.customerIdEdit = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.findCustomer = new System.Windows.Forms.Button();
            this.addCustomerPanel = new System.Windows.Forms.Panel();
            this.successfulLabel = new System.Windows.Forms.Label();
            this.errorAccountNumberLabel = new System.Windows.Forms.Label();
            this.errorAccountHolderNameLabel = new System.Windows.Forms.Label();
            this.errorBankNameLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.creditCardEdit = new System.Windows.Forms.TextBox();
            this.returnToMainButton = new System.Windows.Forms.Button();
            this.creditCardForEdit = new System.Windows.Forms.Label();
            this.accountNumberEdit = new System.Windows.Forms.TextBox();
            this.accountNumberForEdit = new System.Windows.Forms.Label();
            this.accountHolderNameEdit = new System.Windows.Forms.TextBox();
            this.accountHolderNameForEdit = new System.Windows.Forms.Label();
            this.bankNameEdit = new System.Windows.Forms.TextBox();
            this.bankNameLabelForEdit = new System.Windows.Forms.Label();
            this.returnToMainFromProfileButton = new System.Windows.Forms.Button();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.accountHolderNameLabel = new System.Windows.Forms.Label();
            this.banckNameLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.addCustomerPanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.errorLabel);
            this.mainPanel.Controls.Add(this.customerIdEdit);
            this.mainPanel.Controls.Add(this.addCustomer);
            this.mainPanel.Controls.Add(this.findCustomer);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(480, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(127, 147);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 3;
            // 
            // customerIdEdit
            // 
            this.customerIdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.customerIdEdit.Location = new System.Drawing.Point(130, 172);
            this.customerIdEdit.Name = "customerIdEdit";
            this.customerIdEdit.Size = new System.Drawing.Size(216, 38);
            this.customerIdEdit.TabIndex = 2;
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(130, 304);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(216, 51);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // findCustomer
            // 
            this.findCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCustomer.Location = new System.Drawing.Point(130, 233);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(216, 43);
            this.findCustomer.TabIndex = 0;
            this.findCustomer.Text = "Find";
            this.findCustomer.UseVisualStyleBackColor = true;
            this.findCustomer.Click += new System.EventHandler(this.findCustomer_Click);
            // 
            // addCustomerPanel
            // 
            this.addCustomerPanel.Controls.Add(this.successfulLabel);
            this.addCustomerPanel.Controls.Add(this.errorAccountNumberLabel);
            this.addCustomerPanel.Controls.Add(this.errorAccountHolderNameLabel);
            this.addCustomerPanel.Controls.Add(this.errorBankNameLabel);
            this.addCustomerPanel.Controls.Add(this.addCustomerButton);
            this.addCustomerPanel.Controls.Add(this.creditCardEdit);
            this.addCustomerPanel.Controls.Add(this.returnToMainButton);
            this.addCustomerPanel.Controls.Add(this.creditCardForEdit);
            this.addCustomerPanel.Controls.Add(this.accountNumberEdit);
            this.addCustomerPanel.Controls.Add(this.accountNumberForEdit);
            this.addCustomerPanel.Controls.Add(this.accountHolderNameEdit);
            this.addCustomerPanel.Controls.Add(this.accountHolderNameForEdit);
            this.addCustomerPanel.Controls.Add(this.bankNameEdit);
            this.addCustomerPanel.Controls.Add(this.bankNameLabelForEdit);
            this.addCustomerPanel.Location = new System.Drawing.Point(0, 0);
            this.addCustomerPanel.Name = "addCustomerPanel";
            this.addCustomerPanel.Size = new System.Drawing.Size(480, 600);
            this.addCustomerPanel.TabIndex = 5;
            this.addCustomerPanel.Visible = false;
            // 
            // successfulLabel
            // 
            this.successfulLabel.AutoSize = true;
            this.successfulLabel.BackColor = System.Drawing.SystemColors.Control;
            this.successfulLabel.ForeColor = System.Drawing.Color.Green;
            this.successfulLabel.Location = new System.Drawing.Point(326, 374);
            this.successfulLabel.Name = "successfulLabel";
            this.successfulLabel.Size = new System.Drawing.Size(0, 16);
            this.successfulLabel.TabIndex = 12;
            // 
            // errorAccountNumberLabel
            // 
            this.errorAccountNumberLabel.AutoSize = true;
            this.errorAccountNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorAccountNumberLabel.Location = new System.Drawing.Point(23, 281);
            this.errorAccountNumberLabel.Name = "errorAccountNumberLabel";
            this.errorAccountNumberLabel.Size = new System.Drawing.Size(0, 16);
            this.errorAccountNumberLabel.TabIndex = 11;
            this.errorAccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // errorAccountHolderNameLabel
            // 
            this.errorAccountHolderNameLabel.AutoSize = true;
            this.errorAccountHolderNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorAccountHolderNameLabel.Location = new System.Drawing.Point(23, 161);
            this.errorAccountHolderNameLabel.Name = "errorAccountHolderNameLabel";
            this.errorAccountHolderNameLabel.Size = new System.Drawing.Size(0, 16);
            this.errorAccountHolderNameLabel.TabIndex = 10;
            this.errorAccountHolderNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorBankNameLabel
            // 
            this.errorBankNameLabel.AutoSize = true;
            this.errorBankNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorBankNameLabel.Location = new System.Drawing.Point(23, 50);
            this.errorBankNameLabel.Name = "errorBankNameLabel";
            this.errorBankNameLabel.Size = new System.Drawing.Size(0, 16);
            this.errorBankNameLabel.TabIndex = 9;
            this.errorBankNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(329, 502);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(132, 43);
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // creditCardEdit
            // 
            this.creditCardEdit.Enabled = false;
            this.creditCardEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardEdit.Location = new System.Drawing.Point(26, 405);
            this.creditCardEdit.Name = "creditCardEdit";
            this.creditCardEdit.Size = new System.Drawing.Size(435, 38);
            this.creditCardEdit.TabIndex = 7;
            // 
            // returnToMainButton
            // 
            this.returnToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainButton.Location = new System.Drawing.Point(26, 502);
            this.returnToMainButton.Name = "returnToMainButton";
            this.returnToMainButton.Size = new System.Drawing.Size(132, 43);
            this.returnToMainButton.TabIndex = 0;
            this.returnToMainButton.Text = "<< Back";
            this.returnToMainButton.UseVisualStyleBackColor = true;
            this.returnToMainButton.Click += new System.EventHandler(this.returnToMainButton_Click);
            // 
            // creditCardForEdit
            // 
            this.creditCardForEdit.AutoSize = true;
            this.creditCardForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardForEdit.Location = new System.Drawing.Point(20, 361);
            this.creditCardForEdit.Name = "creditCardForEdit";
            this.creditCardForEdit.Size = new System.Drawing.Size(166, 32);
            this.creditCardForEdit.TabIndex = 6;
            this.creditCardForEdit.Text = "Credit Card:";
            // 
            // accountNumberEdit
            // 
            this.accountNumberEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberEdit.Location = new System.Drawing.Point(26, 299);
            this.accountNumberEdit.Name = "accountNumberEdit";
            this.accountNumberEdit.Size = new System.Drawing.Size(435, 38);
            this.accountNumberEdit.TabIndex = 5;
            // 
            // accountNumberForEdit
            // 
            this.accountNumberForEdit.AutoSize = true;
            this.accountNumberForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberForEdit.Location = new System.Drawing.Point(20, 249);
            this.accountNumberForEdit.Name = "accountNumberForEdit";
            this.accountNumberForEdit.Size = new System.Drawing.Size(232, 32);
            this.accountNumberForEdit.TabIndex = 4;
            this.accountNumberForEdit.Text = "Account Number:";
            // 
            // accountHolderNameEdit
            // 
            this.accountHolderNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountHolderNameEdit.Location = new System.Drawing.Point(26, 180);
            this.accountHolderNameEdit.Name = "accountHolderNameEdit";
            this.accountHolderNameEdit.Size = new System.Drawing.Size(435, 38);
            this.accountHolderNameEdit.TabIndex = 3;
            // 
            // accountHolderNameForEdit
            // 
            this.accountHolderNameForEdit.AutoSize = true;
            this.accountHolderNameForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountHolderNameForEdit.Location = new System.Drawing.Point(20, 128);
            this.accountHolderNameForEdit.Name = "accountHolderNameForEdit";
            this.accountHolderNameForEdit.Size = new System.Drawing.Size(298, 32);
            this.accountHolderNameForEdit.TabIndex = 2;
            this.accountHolderNameForEdit.Text = "Account Holder Name:";
            // 
            // bankNameEdit
            // 
            this.bankNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameEdit.Location = new System.Drawing.Point(26, 67);
            this.bankNameEdit.Name = "bankNameEdit";
            this.bankNameEdit.Size = new System.Drawing.Size(435, 38);
            this.bankNameEdit.TabIndex = 1;
            // 
            // bankNameLabelForEdit
            // 
            this.bankNameLabelForEdit.AutoSize = true;
            this.bankNameLabelForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameLabelForEdit.Location = new System.Drawing.Point(20, 18);
            this.bankNameLabelForEdit.Name = "bankNameLabelForEdit";
            this.bankNameLabelForEdit.Size = new System.Drawing.Size(169, 32);
            this.bankNameLabelForEdit.TabIndex = 0;
            this.bankNameLabelForEdit.Text = "Bank Name:";
            // 
            // returnToMainFromProfileButton
            // 
            this.returnToMainFromProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainFromProfileButton.Location = new System.Drawing.Point(28, 502);
            this.returnToMainFromProfileButton.Name = "returnToMainFromProfileButton";
            this.returnToMainFromProfileButton.Size = new System.Drawing.Size(132, 43);
            this.returnToMainFromProfileButton.TabIndex = 5;
            this.returnToMainFromProfileButton.Text = "<< Back";
            this.returnToMainFromProfileButton.UseVisualStyleBackColor = true;
            this.returnToMainFromProfileButton.Click += new System.EventHandler(this.returnToMainFromProfileButton_Click);
            // 
            // customerPanel
            // 
            this.customerPanel.Controls.Add(this.accountNumberLabel);
            this.customerPanel.Controls.Add(this.returnToMainFromProfileButton);
            this.customerPanel.Controls.Add(this.creditCardLabel);
            this.customerPanel.Controls.Add(this.accountHolderNameLabel);
            this.customerPanel.Controls.Add(this.banckNameLabel);
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(480, 600);
            this.customerPanel.TabIndex = 3;
            this.customerPanel.Visible = false;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(19, 255);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(232, 32);
            this.accountNumberLabel.TabIndex = 3;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardLabel.Location = new System.Drawing.Point(20, 361);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(166, 32);
            this.creditCardLabel.TabIndex = 4;
            this.creditCardLabel.Text = "Credit Card:";
            // 
            // accountHolderNameLabel
            // 
            this.accountHolderNameLabel.AutoSize = true;
            this.accountHolderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountHolderNameLabel.Location = new System.Drawing.Point(19, 134);
            this.accountHolderNameLabel.Name = "accountHolderNameLabel";
            this.accountHolderNameLabel.Size = new System.Drawing.Size(298, 32);
            this.accountHolderNameLabel.TabIndex = 2;
            this.accountHolderNameLabel.Text = "Account Holder Name:";
            // 
            // banckNameLabel
            // 
            this.banckNameLabel.AutoSize = true;
            this.banckNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banckNameLabel.Location = new System.Drawing.Point(22, 21);
            this.banckNameLabel.Name = "banckNameLabel";
            this.banckNameLabel.Size = new System.Drawing.Size(169, 32);
            this.banckNameLabel.TabIndex = 1;
            this.banckNameLabel.Text = "Bank Name:";
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 595);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.addCustomerPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "Bank";
            this.Text = "Bank";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addCustomerPanel.ResumeLayout(false);
            this.addCustomerPanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox customerIdEdit;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button findCustomer;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Button returnToMainButton;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label accountHolderNameLabel;
        private System.Windows.Forms.Label banckNameLabel;
        private System.Windows.Forms.Panel addCustomerPanel;
        private System.Windows.Forms.TextBox accountNumberEdit;
        private System.Windows.Forms.Label accountNumberForEdit;
        private System.Windows.Forms.TextBox accountHolderNameEdit;
        private System.Windows.Forms.Label accountHolderNameForEdit;
        private System.Windows.Forms.TextBox bankNameEdit;
        private System.Windows.Forms.Label bankNameLabelForEdit;
        private System.Windows.Forms.TextBox creditCardEdit;
        private System.Windows.Forms.Label creditCardForEdit;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button returnToMainFromProfileButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorAccountNumberLabel;
        private System.Windows.Forms.Label errorAccountHolderNameLabel;
        private System.Windows.Forms.Label errorBankNameLabel;
        private System.Windows.Forms.Label successfulLabel;
    }
}

