using FolderOrganiser.Models;
using FolderOrganiser.ViewModels;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolderOrganiser;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Open Folder Button
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new Microsoft.Win32.OpenFolderDialog();
        if (dialog.ShowDialog() == true)
        {
            if (DataContext is CoreViewModel vm)
            {
                vm.Path = dialog.FolderName;

                vm.registerFiles(Directory.GetFiles(vm.Path).ToList());
            }
        }
    }
}