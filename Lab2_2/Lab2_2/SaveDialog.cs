using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Lab2_2
{
    public class SaveDialog : Dialog
    {       
        static public SaveFileDialog CreateSaveDialog()
        {            
            // Create dialog for seleting a place to save a file 
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //  Set filter of files
            saveFileDialog.Filter = $"Files (*{Data.GetFormat()})|*{Data.GetFormat()}";

            // Set initial directory
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Set initial file name
            saveFileDialog.FileName = Data.GetName();
     
            return saveFileDialog;
        }

        static public bool ConfirmSaving(SaveFileDialog saveFileDialog)
        {         
            return saveFileDialog.ShowDialog() == DialogResult.OK ? true : false;
        }

        static public void WriteFile(SaveFileDialog saveFileDialog)
        {
            string filePath = saveFileDialog.FileName;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write message into the file
                writer.WriteLine(Data.GetMessage());
            }
        }
    }
}
