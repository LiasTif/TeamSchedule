using System.Collections.ObjectModel;
using TeamScheduleApp.ViewModels;
using TeamScheduleApp.ViewModels.Elements;

namespace TeamScheduleApp.Models.RegistrationModels
{
    public class ContinueButtonProcessor : BaseViewModel
    {
        #region properties
        private bool _isContinueButEnable = false;
        public bool IsContinueButEnable
        {
            get { return _isContinueButEnable; }
            set { SetField(ref _isContinueButEnable, value); }
        }
        #endregion

        public void SetButtonStatus(ObservableCollection<TextBoxViewModel> textBoxes, string firstName, string lastName)
        {
            // IsContinueButEnable is true by default, if one field empty - change it to false
            IsContinueButEnable = true;
            if ((firstName == null || firstName == "") || (lastName == null || lastName == ""))
                IsContinueButEnable = false;
            else
                foreach (TextBoxViewModel textBox in textBoxes)
                    if (textBox.Text == null || textBox.Text == "")
                        IsContinueButEnable = false;
        }
    }
}