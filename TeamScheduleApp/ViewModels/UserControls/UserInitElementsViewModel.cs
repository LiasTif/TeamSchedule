﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using TeamScheduleApp.API;
using TeamScheduleApp.Models.RegistrationModels;
using TeamScheduleApp.ViewModels.Elements;

namespace TeamScheduleApp.ViewModels.UserControls
{
    public class UserInitElementsViewModel : BaseViewModel
    {
        // Count of numbers in pin code
        private const byte TextBoxesCount = 4;

        #region properties
        public ContinueButtonProcessor ContinueButtonProcessor { get; set; } = new ContinueButtonProcessor();
        public PersonDataProcessor PersonDataProcessor { get; set; }
        public ObservableCollection<TextBoxViewModel> TextBoxes { get; set; }
        #endregion

        #region commands
        public ICommand NavigateLaunchView { get; }
        #endregion

        /// <summary>
        /// RegistrationViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public UserInitElementsViewModel(NavigationStore navigationStore)
        {
            // Create TextBoxes and add it`s to ObservableCollection
            TextBoxes = new ObservableCollection<TextBoxViewModel>();
            for (int i = 0; i < TextBoxesCount; i++) { TextBoxes.Add(new TextBoxViewModel(this) { Id = i }); }

            PersonDataProcessor = new PersonDataProcessor(this);

            // Set LaunchViewModel like CurrentViewModel
            NavigateLaunchView = CommandFromFunction(x => navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore));
        }
    }
}