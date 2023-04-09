using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.UserControls
{
    public class RegistrationViewModel : BaseViewModel
    {
        public NavigationStore NavigationStore { get; set; }
        public UserInitElementsViewModel UserInitElementsViewModel { get; set; }

        /// <summary>
        /// RegistrationViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public RegistrationViewModel(NavigationStore navigationStore)
        {
            NavigationStore = navigationStore;
        }
    }
}