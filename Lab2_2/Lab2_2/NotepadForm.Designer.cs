namespace Lab2_2
{
    partial class NotepadForm
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
            inputText = new TextBox();
            formatsComboBox = new ComboBox();
            nameText = new TextBox();
            menuStrip1 = new MenuStrip();
            saveMenu = new ToolStripMenuItem();
            openMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inputText
            // 
            inputText.Location = new Point(9, 87);
            inputText.Multiline = true;
            inputText.Name = "inputText";
            inputText.Size = new Size(1128, 761);
            inputText.TabIndex = 1;
            // 
            // formatsComboBox
            // 
            formatsComboBox.FormattingEnabled = true;
            formatsComboBox.Location = new Point(875, 42);
            formatsComboBox.Name = "formatsComboBox";
            formatsComboBox.Size = new Size(262, 40);
            formatsComboBox.TabIndex = 2;
            // 
            // nameText
            // 
            nameText.Location = new Point(9, 42);
            nameText.Name = "nameText";
            nameText.Size = new Size(860, 39);
            nameText.TabIndex = 4;
            nameText.Text = "NameOfTheFile";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveMenu, openMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 42);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveMenu
            // 
            saveMenu.Name = "saveMenu";
            saveMenu.Size = new Size(84, 38);
            saveMenu.Text = "Save";
            saveMenu.Click += saveMenu_Click;
            // 
            // openMenu
            // 
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(93, 38);
            openMenu.Text = "Open";
            openMenu.Click += openMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 860);
            Controls.Add(nameText);
            Controls.Add(formatsComboBox);
            Controls.Add(inputText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Lab2_2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputText;
        private ComboBox formatsComboBox;
        private TextBox nameText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveMenu;
        private ToolStripMenuItem openMenu;
    }
}