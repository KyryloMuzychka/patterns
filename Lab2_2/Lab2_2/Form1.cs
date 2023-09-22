using System.Security.Cryptography;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormatsComboBox();
        }

        /// <summary>
        /// Add options for ComboBox
        /// </summary>
        private void InitializeFormatsComboBox()
        {
            formatsComboBox.Items.Add(Format.TXT);
            formatsComboBox.Items.Add(Format.BAT);
            formatsComboBox.SelectedItem = Format.TXT;
        }

        public ComboBox GetFormatsComboBox()
        {
            return formatsComboBox;
        }

        public TextBox GetInputText()
        {
            return inputText;
        }

        public TextBox GetNameText()
        {
            return nameText;
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {           
            // Create dialog for saving a file
            SaveFileDialog saveFileDialog = SaveDialog.CreateSaveDialog(this);

            // If result of dialog is OK
            if (SaveDialog.ConfirmSaving(saveFileDialog))
            {
                // Create a FileLoggerFactory
                ILoggerFactory fileLoggerFactory = new FileLoggerFactory(SaveDialog.GetName());

                // Create a logger using the FileLoggerFactory
                ILogger fileLogger = fileLoggerFactory.createLogger();
                fileLogger.log(SaveDialog.GetName());

                SaveDialog.WriteFile(saveFileDialog);
            }           
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            // Create dialog for opening a file
            OpenFileDialog openFileDialog = OpenDialog.CreateOpenDialog(this);

            // Show the OpenFileDialog and wait for the user to select a file
            if (OpenDialog.ConfirmOpening(openFileDialog))
            {                                             
                try
                {                 
                    // Reading file
                    OpenDialog.OpenFile(this, openFileDialog);

                    // Create a StdoutLoggerFactory
                    ILoggerFactory stdoutLoggerFactory = new StdoutLoggerFactory();

                    // Create a logger using the StdoutLoggerFactory
                    ILogger stdoutLogger = stdoutLoggerFactory.createLogger();
                                     
                    stdoutLogger.log(Dialog.GetName());
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }         
        }


    }
}