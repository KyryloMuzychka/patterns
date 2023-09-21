using System.Security.Cryptography;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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

        private void saveMenu_Click(object sender, EventArgs e)
        {
            // Get data
            string message = inputText.Text;
            string name = nameText.Text;
            string format = formatsComboBox.SelectedItem.ToString();

            // Create dialog for seleting a place to save a file 
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //  Set filter of files
            saveFileDialog.Filter = $"Files (*{format})|*{format}";

            // Set initial directory
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Set initial file name
            saveFileDialog.FileName = name;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get chosen path and the name of the file
                string filePath = saveFileDialog.FileName;
                
                // Create a FileLoggerFactory
                LoggerFactory fileLoggerFactory = new FileLoggerFactory(filePath);

                // Create a logger using the FileLoggerFactory
                Logger fileLogger = fileLoggerFactory.createLogger();
                fileLogger.log(message);
            }
        }

        private void openMenu_Click(object sender, EventArgs e)
        {

            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Set the filter for the file allowed types
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Bat Files (*.bat)|*.bat";
           
            // Show the OpenFileDialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path and the name of the file
                string filePath = openFileDialog.FileName;
                              
                try
                {
                    // Create a StdoutLoggerFactory
                    LoggerFactory stdoutLoggerFactory = new StdoutLoggerFactory();

                    // Create a logger using the StdoutLoggerFactory
                    Logger stdoutLogger = stdoutLoggerFactory.createLogger();
                    
                    using (StreamReader reader = new StreamReader(filePath))
                    {                        
                        inputText.Text = reader.ReadToEnd();
                    }
                   
                    nameText.Text = GetName(Path.GetFileName(filePath));
                    formatsComboBox.SelectedItem = Path.GetExtension(filePath);

                    stdoutLogger.log(filePath);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("An error occurred while reading the file: " + ex.Message);
                }
            }         
        }

        private string GetName(string name)
        {
            string fileName = "";
            foreach (char c in name)
            {  
                if (c == '.') 
                {
                    break;
                }
                fileName += c;
            }
            return fileName;
        }
    }
}