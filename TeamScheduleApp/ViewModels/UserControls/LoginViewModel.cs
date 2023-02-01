using System.Windows.Input;
using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.UserControls
{
    /// <summary>
    /// ViewModel for LoginView.xaml
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region commands
        public ICommand NavigateLaunchView { get; }
        #endregion

        /// <summary>
        /// LoginViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public LoginViewModel(NavigationStore navigationStore)
        {
            // Set LaunchViewModel like CurrentViewModel
            NavigateLaunchView = CommandFromFunction(x => navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore));
        }
    }
}