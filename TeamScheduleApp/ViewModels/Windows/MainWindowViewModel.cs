using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.Windows
{
    /// <summary>
    /// ViewModel for MainWindow.xaml
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            //_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        //private void OnCurrentViewModelChanged()
        //{
        //    OnPropertyChanged(nameof(CurrentViewModel));
        //}
    }
}