using System.Collections.ObjectModel;
using System.Windows.Input;
using TeamScheduleApp.API;
using TeamScheduleApp.ViewModels.Elements;

namespace TeamScheduleApp.ViewModels.UserControls
{
    /// <summary>
    /// ViewModel for RegistrationView.xaml
    /// </summary>
    public class RegistrationViewModel : BaseViewModel
    {
        // Count of numbers in pin code
        private const byte TextBoxesCount = 4;
        #region commands
        public ICommand NavigateLaunchView { get; }
        #endregion
        #region properties
        public ObservableCollection<RegistrationTextBoxViewModel> TextBoxes { get; set; }
        #endregion

        /// <summary>
        /// RegistrationViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public RegistrationViewModel(NavigationStore navigationStore)
        {
            // Set LaunchViewModel like CurrentViewModel
            NavigateLaunchView = CommandFromFunction(x => navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore));

            // Create TextBoxes and add it`s to ObservableCollection
            TextBoxes = new ObservableCollection<RegistrationTextBoxViewModel>();
            for (int i = 0; i < TextBoxesCount; i++)
            {
                TextBoxes.Add(new RegistrationTextBoxViewModel() { Id = i });
            }
        }
    }
}