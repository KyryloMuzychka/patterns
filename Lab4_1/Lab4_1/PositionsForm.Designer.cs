namespace Lab4_1
{
    partial class PositionsMainForm
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
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.positionsListView = new System.Windows.Forms.ListView();
            this.surnameEdit = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.removeWorkerButton = new System.Windows.Forms.Button();
            this.surnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AppointmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(60, 240);
            this.addWorkerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(212, 42);
            this.addWorkerButton.TabIndex = 0;
            this.addWorkerButton.Text = "Add Worker";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // positionsListView
            // 
            this.positionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.surnameColumn,
            this.AppointmentColumn,
            this.taskColumn});
            this.positionsListView.HideSelection = false;
            this.positionsListView.Location = new System.Drawing.Point(309, 58);
            this.positionsListView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.positionsListView.Name = "positionsListView";
            this.positionsListView.Size = new System.Drawing.Size(931, 321);
            this.positionsListView.TabIndex = 1;
            this.positionsListView.UseCompatibleStateImageBehavior = false;
            this.positionsListView.View = System.Windows.Forms.View.Details;
            // 
            // surnameEdit
            // 
            this.surnameEdit.Location = new System.Drawing.Point(60, 146);
            this.surnameEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.surnameEdit.Name = "surnameEdit";
            this.surnameEdit.Size = new System.Drawing.Size(209, 34);
            this.surnameEdit.TabIndex = 2;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(60, 58);
            this.positionComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(209, 37);
            this.positionComboBox.TabIndex = 3;
            // 
            // removeWorkerButton
            // 
            this.removeWorkerButton.Location = new System.Drawing.Point(60, 337);
            this.removeWorkerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.removeWorkerButton.Name = "removeWorkerButton";
            this.removeWorkerButton.Size = new System.Drawing.Size(212, 42);
            this.removeWorkerButton.TabIndex = 4;
            this.removeWorkerButton.Text = "Remove Worker";
            this.removeWorkerButton.UseVisualStyleBackColor = true;
            this.removeWorkerButton.Click += new System.EventHandler(this.removeWorkerButton_Click);
            // 
            // surnameColumn
            // 
            this.surnameColumn.Text = "Surname";
            this.surnameColumn.Width = 328;
            // 
            // AppointmentColumn
            // 
            this.AppointmentColumn.Text = "Appointment";
            this.AppointmentColumn.Width = 240;
            // 
            // taskColumn
            // 
            this.taskColumn.Text = "Task";
            this.taskColumn.Width = 340;
            // 
            // PositionsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 437);
            this.Controls.Add(this.removeWorkerButton);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.surnameEdit);
            this.Controls.Add(this.positionsListView);
            this.Controls.Add(this.addWorkerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PositionsMainForm";
            this.Text = "Positions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.ListView positionsListView;
        private System.Windows.Forms.TextBox surnameEdit;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Button removeWorkerButton;
        private System.Windows.Forms.ColumnHeader surnameColumn;
        private System.Windows.Forms.ColumnHeader AppointmentColumn;
        private System.Windows.Forms.ColumnHeader taskColumn;
    }
}

