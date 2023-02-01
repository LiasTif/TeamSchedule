using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.Windows
{
    /// <summary>
    /// ViewModel for MainWindow.xaml
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        // current NavigationStore buffer
        private readonly NavigationStore NavigationStore;

        // CurrentViewModel buffer
        public BaseViewModel CurrentViewModel => NavigationStore.CurrentViewModel;

        public MainWindowViewModel(NavigationStore navigationStore)
        {
            NavigationStore = navigationStore;

            // UpdateProperty if is a CurrentViewModel property
            navigationStore.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "CurrentViewModel") OnPropertyChanged("CurrentViewModel");
            };
        }
    }
}