namespace FileExplorer.ViewModels
{
    using FileExplorer.ViewModels.Interfaces;


    /// <summary>
    /// This is main view model
    /// </summary>
    internal class MainViewModel : ViewModelBase, IMainViewModel
    {
        public MainViewModel(IFileSystemStructureViewModel fileSystemStructureViewModel, IFolderContentViewModel folderContentViewModel)
        {
            FileSystemStructureViewModel = fileSystemStructureViewModel;
            FolderContentViewModel = folderContentViewModel;
        }

        public IFileSystemStructureViewModel FileSystemStructureViewModel { get; }

        public IFolderContentViewModel FolderContentViewModel { get; }
    }
}