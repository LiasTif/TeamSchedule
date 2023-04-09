using TeamScheduleApp.ViewModels;
using TeamScheduleApp.ViewModels.UserControls;

namespace TeamScheduleApp.Models.RegistrationModels
{
    public class PersonDataProcessor : BaseViewModel
    {
        public UserInitElementsViewModel ParentVM { get; set; }
        public PersonDataProcessor(UserInitElementsViewModel parentVM) { ParentVM = parentVM; }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                ParentVM.ContinueButtonProcessor.SetButtonStatus(ParentVM.TextBoxes, FirstName, LastName);
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                ParentVM.ContinueButtonProcessor.SetButtonStatus(ParentVM.TextBoxes, FirstName, LastName);
            }
        }
    }
}
