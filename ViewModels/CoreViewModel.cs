using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FolderOrganiser.Models;
using System.Collections.ObjectModel;

namespace FolderOrganiser.ViewModels
{
    
    public partial class CoreViewModel : ObservableObject
    {
        private FileService _fs;

        [ObservableProperty]
        public partial String Path { get; set; } = String.Empty;
        [ObservableProperty]
        public partial ObservableCollection<FOFile> Files { get; set; } = new ObservableCollection<FOFile>();

        [ObservableProperty]
        private ObservableCollection<FileItem> _files = new();

        [RelayCommand]
        private void AddFile()
        {
            _files.Add(new FileItem { FileName = "NewFile.txt" });
        }

        public CoreViewModel()
        {
            _fs = new FileService();
        }

        public void registerFiles(List<string> filePaths)
        {
            foreach (string f in filePaths)
            {
                _fs.AddFile(f);
            }
            Files = new ObservableCollection<FOFile>(_fs.files); 
        }
    }

    public partial class FileItem : ObservableObject
    {
        [ObservableProperty]
        private string _fileName = "";
    }
}
