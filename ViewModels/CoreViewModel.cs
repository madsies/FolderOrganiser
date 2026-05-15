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


            Files.Clear();
            foreach (var file in _fs.files)
            {
                Files.Add(file);
            }
        }
    }

    public partial class FileItem : ObservableObject
    {
        [ObservableProperty]
        private string _fileName = "";
    }
}
