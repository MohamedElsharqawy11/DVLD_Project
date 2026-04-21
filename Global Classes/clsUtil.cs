using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Global_Classes
{
    public class clsUtil
    {

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error  : " + e.Message);
                    return false;
                }
            }
            return true;
        }
        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            string FileName = SourceFile;
            FileInfo fI = new FileInfo(FileName);
            string Extn = fI.Extension;
            return GenerateGUID() + Extn;
        }
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            //Identify string DestinationFilePathFolder ifCreated or not
            //Identify DFile With GUID 
            string DestinationFolder = @"C:\DVLD_Images_Folder\";
            if (CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }
            string DestinatinFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, DestinatinFile, true);
            }
            catch (IOException e)
            {
                MessageBox.Show(" Error : ", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = DestinatinFile;
            return true;
        }

    }
}
