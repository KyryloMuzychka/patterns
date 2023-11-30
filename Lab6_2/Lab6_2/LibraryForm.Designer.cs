namespace Lab6_2
{
    partial class LibraryForm
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
            this.BookListView = new System.Windows.Forms.ListView();
            this.RemoveBookButton = new System.Windows.Forms.Button();
            this.DeleteEdit = new System.Windows.Forms.TextBox();
            this.TitleEdit = new System.Windows.Forms.TextBox();
            this.AddBookEdit = new System.Windows.Forms.Button();
            this.AuthorEdit = new System.Windows.Forms.TextBox();
            this.PublisherEdit = new System.Windows.Forms.TextBox();
            this.YearEdit = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.IteratorLabel = new System.Windows.Forms.Label();
            this.IteratorComboBox = new System.Windows.Forms.ComboBox();
            this.SortedBooksListView = new System.Windows.Forms.ListView();
            this.SortedLabel = new System.Windows.Forms.Label();
            this.SortingParameterEdit = new System.Windows.Forms.TextBox();
            this.ParameterSortLabel = new System.Windows.Forms.Label();
            this.adviseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(283, 47);
            this.BookListView.Margin = new System.Windows.Forms.Padding(4);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(531, 601);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            // 
            // RemoveBookButton
            // 
            this.RemoveBookButton.Location = new System.Drawing.Point(33, 242);
            this.RemoveBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBookButton.Name = "RemoveBookButton";
            this.RemoveBookButton.Size = new System.Drawing.Size(224, 56);
            this.RemoveBookButton.TabIndex = 1;
            this.RemoveBookButton.Text = "Remove";
            this.RemoveBookButton.UseVisualStyleBackColor = true;
            this.RemoveBookButton.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // DeleteEdit
            // 
            this.DeleteEdit.Location = new System.Drawing.Point(33, 179);
            this.DeleteEdit.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteEdit.Name = "DeleteEdit";
            this.DeleteEdit.Size = new System.Drawing.Size(224, 30);
            this.DeleteEdit.TabIndex = 2;
            // 
            // TitleEdit
            // 
            this.TitleEdit.Location = new System.Drawing.Point(33, 337);
            this.TitleEdit.Margin = new System.Windows.Forms.Padding(4);
            this.TitleEdit.Name = "TitleEdit";
            this.TitleEdit.Size = new System.Drawing.Size(224, 30);
            this.TitleEdit.TabIndex = 4;
            // 
            // AddBookEdit
            // 
            this.AddBookEdit.Location = new System.Drawing.Point(33, 592);
            this.AddBookEdit.Margin = new System.Windows.Forms.Padding(4);
            this.AddBookEdit.Name = "AddBookEdit";
            this.AddBookEdit.Size = new System.Drawing.Size(224, 56);
            this.AddBookEdit.TabIndex = 3;
            this.AddBookEdit.Text = "Add";
            this.AddBookEdit.UseVisualStyleBackColor = true;
            this.AddBookEdit.Click += new System.EventHandler(this.AddBookEdit_Click);
            // 
            // AuthorEdit
            // 
            this.AuthorEdit.Location = new System.Drawing.Point(33, 400);
            this.AuthorEdit.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorEdit.Name = "AuthorEdit";
            this.AuthorEdit.Size = new System.Drawing.Size(224, 30);
            this.AuthorEdit.TabIndex = 5;
            // 
            // PublisherEdit
            // 
            this.PublisherEdit.Location = new System.Drawing.Point(33, 472);
            this.PublisherEdit.Margin = new System.Windows.Forms.Padding(4);
            this.PublisherEdit.Name = "PublisherEdit";
            this.PublisherEdit.Size = new System.Drawing.Size(224, 30);
            this.PublisherEdit.TabIndex = 6;
            // 
            // YearEdit
            // 
            this.YearEdit.Location = new System.Drawing.Point(33, 539);
            this.YearEdit.Margin = new System.Windows.Forms.Padding(4);
            this.YearEdit.Name = "YearEdit";
            this.YearEdit.Size = new System.Drawing.Size(224, 30);
            this.YearEdit.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(33, 310);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 25);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title:";
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(33, 373);
            this.AuthorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(86, 25);
            this.AuthorsLabel.TabIndex = 9;
            this.AuthorsLabel.Text = "Authors:";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(33, 445);
            this.PublisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(99, 25);
            this.PublisherLabel.TabIndex = 10;
            this.PublisherLabel.Text = "Publisher:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(33, 511);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(59, 25);
            this.YearLabel.TabIndex = 11;
            this.YearLabel.Text = "Year:";
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Location = new System.Drawing.Point(278, 18);
            this.BooksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(73, 25);
            this.BooksLabel.TabIndex = 12;
            this.BooksLabel.Text = "Books:";
            // 
            // IteratorLabel
            // 
            this.IteratorLabel.AutoSize = true;
            this.IteratorLabel.Location = new System.Drawing.Point(28, 18);
            this.IteratorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IteratorLabel.Name = "IteratorLabel";
            this.IteratorLabel.Size = new System.Drawing.Size(78, 25);
            this.IteratorLabel.TabIndex = 13;
            this.IteratorLabel.Text = "Iterator:";
            // 
            // IteratorComboBox
            // 
            this.IteratorComboBox.FormattingEnabled = true;
            this.IteratorComboBox.Location = new System.Drawing.Point(33, 47);
            this.IteratorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.IteratorComboBox.Name = "IteratorComboBox";
            this.IteratorComboBox.Size = new System.Drawing.Size(224, 33);
            this.IteratorComboBox.TabIndex = 14;
            this.IteratorComboBox.SelectedIndexChanged += new System.EventHandler(this.IteratorComboBox_SelectedIndexChanged);
            // 
            // SortedBooksListView
            // 
            this.SortedBooksListView.HideSelection = false;
            this.SortedBooksListView.Location = new System.Drawing.Point(845, 47);
            this.SortedBooksListView.Margin = new System.Windows.Forms.Padding(4);
            this.SortedBooksListView.Name = "SortedBooksListView";
            this.SortedBooksListView.Size = new System.Drawing.Size(531, 601);
            this.SortedBooksListView.TabIndex = 16;
            this.SortedBooksListView.UseCompatibleStateImageBehavior = false;
            this.SortedBooksListView.View = System.Windows.Forms.View.Details;
            // 
            // SortedLabel
            // 
            this.SortedLabel.AutoSize = true;
            this.SortedLabel.Location = new System.Drawing.Point(840, 18);
            this.SortedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortedLabel.Name = "SortedLabel";
            this.SortedLabel.Size = new System.Drawing.Size(136, 25);
            this.SortedLabel.TabIndex = 17;
            this.SortedLabel.Text = "Sorted Books:";
            // 
            // SortingParameterEdit
            // 
            this.SortingParameterEdit.Location = new System.Drawing.Point(33, 116);
            this.SortingParameterEdit.Margin = new System.Windows.Forms.Padding(4);
            this.SortingParameterEdit.Name = "SortingParameterEdit";
            this.SortingParameterEdit.Size = new System.Drawing.Size(224, 30);
            this.SortingParameterEdit.TabIndex = 18;
            // 
            // ParameterSortLabel
            // 
            this.ParameterSortLabel.AutoSize = true;
            this.ParameterSortLabel.Location = new System.Drawing.Point(28, 88);
            this.ParameterSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParameterSortLabel.Name = "ParameterSortLabel";
            this.ParameterSortLabel.Size = new System.Drawing.Size(174, 25);
            this.ParameterSortLabel.TabIndex = 19;
            this.ParameterSortLabel.Text = "Sorting Parameter ";
            // 
            // adviseLabel
            // 
            this.adviseLabel.AutoSize = true;
            this.adviseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adviseLabel.Location = new System.Drawing.Point(189, 147);
            this.adviseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adviseLabel.Name = "adviseLabel";
            this.adviseLabel.Size = new System.Drawing.Size(75, 16);
            this.adviseLabel.TabIndex = 20;
            this.adviseLabel.Text = "title/authors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(222, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "code";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adviseLabel);
            this.Controls.Add(this.ParameterSortLabel);
            this.Controls.Add(this.SortingParameterEdit);
            this.Controls.Add(this.SortedLabel);
            this.Controls.Add(this.SortedBooksListView);
            this.Controls.Add(this.IteratorComboBox);
            this.Controls.Add(this.IteratorLabel);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.YearEdit);
            this.Controls.Add(this.PublisherEdit);
            this.Controls.Add(this.AuthorEdit);
            this.Controls.Add(this.TitleEdit);
            this.Controls.Add(this.AddBookEdit);
            this.Controls.Add(this.DeleteEdit);
            this.Controls.Add(this.RemoveBookButton);
            this.Controls.Add(this.BookListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.Button RemoveBookButton;
        private System.Windows.Forms.TextBox DeleteEdit;
        private System.Windows.Forms.TextBox TitleEdit;
        private System.Windows.Forms.Button AddBookEdit;
        private System.Windows.Forms.TextBox AuthorEdit;
        private System.Windows.Forms.TextBox PublisherEdit;
        private System.Windows.Forms.TextBox YearEdit;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.Label IteratorLabel;
        private System.Windows.Forms.ComboBox IteratorComboBox;
        private System.Windows.Forms.ListView SortedBooksListView;
        private System.Windows.Forms.Label SortedLabel;
        private System.Windows.Forms.TextBox SortingParameterEdit;
        private System.Windows.Forms.Label ParameterSortLabel;
        private System.Windows.Forms.Label adviseLabel;
        private System.Windows.Forms.Label label1;
    }
}

