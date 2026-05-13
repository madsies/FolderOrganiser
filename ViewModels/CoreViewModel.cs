using CommunityToolkit.Mvvm.ComponentModel; 

namespace FolderOrganiser.ViewModels
{
    public partial class CoreViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial String Path { get; set; } = String.Empty;

    }
}
