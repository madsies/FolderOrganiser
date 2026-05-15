using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FolderOrganiser.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace FolderOrganiser.ViewModels
{

    public partial class CoreViewModel : ObservableObject
    {
        private FileService _fs;

        [ObservableProperty]
        public partial String Path { get; set; } = String.Empty;
        [ObservableProperty]
        public partial ObservableCollection<FOFile> Files { get; set; } = new ObservableCollection<FOFile>();
        public CoreViewModel()
        {
            _fs = new FileService();
        }

        public void registerFiles(List<string> filePaths)
        {
            _fs.wipeFiles(); // Wipes prev files 
            foreach (string f in filePaths)
            {
                _fs.AddFile(f);
            }

            fillPublicArray();
        }

        public void registerSubFolders(List<string> folderPaths)
        {
            _fs.wipeFolder();
            foreach (string f in folderPaths)
            {
                _fs.AddFolder(f);
            }

            Files.Clear();
            fillPublicArray();
        }

        private void fillPublicArray()
        {
            Files.Clear();
            foreach (var folder in _fs.subFolders)
            {
                Files.Add(folder);
            }
            foreach (var file in _fs.files)
            {
                Files.Add(file);
            }
        }

        public partial class FileItem : ObservableObject
        {
            [ObservableProperty]
            private string _fileName = "";
        }
    }
}
