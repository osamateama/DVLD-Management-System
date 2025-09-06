using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            try
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"D:\C#\project 19\DVLD-people-imgs";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }
            string DestinationFile = Path.Combine(DestinationFolder, ReplaceFileNameWithGUID(sourceFile));
            try
            {
                File.Copy(sourceFile, DestinationFile, true); 
            }
            catch (IOException IOex)
            {
                MessageBox.Show($"Error copying image to project folder: {IOex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = DestinationFile;
            return true;
        }
    }
}
