using TeamScheduleApp.ViewModels;

namespace TeamScheduleApp.API
{
    public class NavigationStore : BaseViewModel
    {
        //public event Action CurrentViewModelChanged;

        //private BaseViewModel _currentViewModel;
        //public BaseViewModel CurrentViewModel
        //{
        //    get => _currentViewModel;
        //    set
        //    {
        //        if (_currentViewModel != value)
        //        {
        //            _currentViewModel = value;
        //            OnCurrentViewModelChanged();
        //        }
        //    }
        //}

        //private void OnCurrentViewModelChanged()
        //{
        //    CurrentViewModelChanged?.Invoke();
        //}

        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set { SetField(ref _currentViewModel, value, "CurrentViewModel"); }
        }
    }
}
