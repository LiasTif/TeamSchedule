using TeamScheduleApp.ViewModels;

namespace TeamScheduleApp.API
{
    /// <summary>
    /// NavigationStore contains CurrentViewModel
    /// </summary>
    public class NavigationStore : BaseViewModel
    {
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set { SetField(ref _currentViewModel, value); }
        }
    }
}