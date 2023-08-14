namespace FileExplorer.ViewModels
{
    using Caliburn.Micro;

    using FileExplorer.Services.Interfaces;
    using FileExplorer.ViewModels.Interfaces;
    using FileExplorer.ViewModels.TreeView;
    using FileExplorer.ViewModels.TreeView.Interfaces;
    using System.IO;
    using System.Linq;

    internal class FileSystemStructureViewModel : ViewModelBase, IFileSystemStructureViewModel
    {
        public FileSystemStructureViewModel(IFileSystemService fileSystemService)
        {

            //Read Recently the 
            Drives = new BindableCollection<IFolderViewModel>(fileSystemService.GetDrives());

            Navigate(@"D:\Hicas\AI");
        }

        public void Navigate(string folderPath)
        {
            string root = Directory.GetDirectoryRoot(folderPath);

            var drive = Drives.FirstOrDefault(x => x.Folder.Path == root);
            if (drive != null)
            {
                DriveViewModel driveVm = ((DriveViewModel)drive);
                driveVm.IsExpanded = true;
                FolderViewModel folderVm = driveVm.Folders.ElementAt(2) as FolderViewModel;
                folderVm.IsSelected = true;
            }
        }

        public IObservableCollection<IFolderViewModel> Drives { get; }
    }
}