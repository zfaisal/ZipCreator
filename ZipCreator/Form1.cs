using Ionic.Zip;
using System;
using System.IO;
using System.Windows.Forms;


namespace ZipCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string startPath = "";
        string zipPath = "";
        string directoryName = "";
        private void btn_File_Chooser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file type";
            string selectedFile = "";
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog.FileName;
                directoryName = Path.GetDirectoryName(selectedFile);
                lbl_filePath.Text = directoryName; 
            }

            
            // now create a zipped folder
             startPath = directoryName;
             zipPath = directoryName +@"\result.zip";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ZipFile zip = new ZipFile())
            {

                // delete the zip file
                File.Delete(directoryName + @"\results.zip");

                DirectoryInfo dirInfo = new DirectoryInfo(directoryName);

                //get all your files in zip except for any .zip version
                foreach (FileInfo info in dirInfo.GetFiles())
                {
                    if (info.Name.EndsWith(".zip"))
                    {
                        continue;
                    }

                    byte[] bytes = File.ReadAllBytes(info.FullName);
                    
                    zip.AddEntry(info.Name, bytes);
                }

                //interate through all the folders
                foreach (DirectoryInfo info in dirInfo.GetDirectories())
                {
                    if (info.Name.EndsWith(".zip"))
                    {
                        continue;
                    }
                    
                    zip.AddItem(info.FullName, info.Name);  // add the folders, their subfolders and all the inner items to zip 
                }

                
                // save the zip file
                zip.Save(directoryName + @"\results.zip");
            }
        }
    }
}
