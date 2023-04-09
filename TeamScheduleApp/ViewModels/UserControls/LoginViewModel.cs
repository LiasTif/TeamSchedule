using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.UserControls
{
    /// <summary>
    /// ViewModel for LoginView.xaml
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        public NavigationStore NavigationStore { get; set; }
        public UserInitElementsViewModel UserInitElementsViewModel { get; set; }

        /// <summary>
        /// LoginViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public LoginViewModel(NavigationStore navigationStore)
        {
            NavigationStore = navigationStore;
        }
    }
}