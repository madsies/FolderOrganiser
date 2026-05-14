using System;
using System.Collections.Generic;
using System.Text;

namespace FolderOrganiser.Models
{
    public class FileService
    {
        public List<FOFile> files = new List<FOFile>();
        public void AddFile(String fileName)
        {
            // Update the file's properties based on its path
            var fileInfo = new System.IO.FileInfo(fileName);
            FOFile newFile = new FOFile();
            newFile.Name = fileInfo.Name;
            newFile.Path = fileInfo.FullName;
            newFile.Extension = fileInfo.Extension;
            newFile.TimeCreated = fileInfo.CreationTime;
            newFile.LastEdited = fileInfo.LastWriteTime;
            newFile.FileSize = (int) fileInfo.Length;
            files.Append(newFile);
            Console.WriteLine("File added");
        }

        public void RemoveFile(String fileName)
        {
            files.RemoveAll(f => f.Path == fileName);
        }
    }
}
