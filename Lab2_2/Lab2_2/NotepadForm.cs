using System.Security.Cryptography;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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

        private void saveMenu_Click(object sender, EventArgs e)
        {
            // Set data
            Data.SetData(inputText.Text, nameText.Text, formatsComboBox.SelectedItem.ToString());

            // Create dialog for saving a file
            SaveFileDialog saveFileDialog = SaveDialog.CreateSaveDialog();

            // If result of dialog is OK
            if (SaveDialog.ConfirmSaving(saveFileDialog))
            {
                // Create a FileLoggerFactory
                ILoggerFactory fileLoggerFactory = new FileLoggerFactory(Data.GetName());

                // Create a logger using the FileLoggerFactory
                ILogger fileLogger = fileLoggerFactory.createLogger();
                fileLogger.log(Data.GetName());

                SaveDialog.WriteFile(saveFileDialog);
            }
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            // Create dialog for opening a file
            OpenFileDialog openFileDialog = OpenDialog.CreateOpenDialog();

            // Show the OpenFileDialog and wait for the user to select a file
            if (OpenDialog.ConfirmOpening(openFileDialog))
            {
                try
                {
                    // Reading file
                    OpenDialog.OpenFile(openFileDialog);

                    // Set data to boxes
                    inputText.Text = Data.GetMessage();
                    nameText.Text = Data.GetName();
                    formatsComboBox.SelectedItem = Data.GetFormat();

                    // Create a StdoutLoggerFactory
                    ILoggerFactory stdoutLoggerFactory = new StdoutLoggerFactory();

                    // Create a logger using the StdoutLoggerFactory
                    ILogger stdoutLogger = stdoutLoggerFactory.createLogger();
                    stdoutLogger.log(Data.GetName());
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}