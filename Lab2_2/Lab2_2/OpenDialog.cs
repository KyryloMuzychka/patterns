using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public class OpenDialog : Dialog
    {
        static public OpenFileDialog CreateOpenDialog()
        {          
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Set the filter for the file allowed types
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Bat Files (*.bat)|*.bat";
            
            return openFileDialog;
        }

        static public bool ConfirmOpening(OpenFileDialog openFileDialog)
        {
            return openFileDialog.ShowDialog() == DialogResult.OK ? true : false;
        }

        static public void OpenFile(OpenFileDialog openFileDialog)
        {
            // Get the selected file's path and the name of the file
            string filePath = openFileDialog.FileName;

            using (StreamReader reader = new StreamReader(filePath))
            {
                Data.SetData(reader.ReadToEnd(), GetNameAndDeleteExtension(Path.GetFileName(filePath)), Path.GetExtension(filePath));                
            }      
        }        
    }
}
