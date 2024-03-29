﻿using System.Windows.Input;
using TeamScheduleApp.API;

namespace TeamScheduleApp.ViewModels.UserControls
{
    /// <summary>
    /// ViewModel for LaunchView.xaml
    /// </summary>
    public class LaunchViewModel : BaseViewModel
    {
        #region commands
        public ICommand NavigateLoginView { get; }
        public ICommand NavigateRegistrationView { get; }
        #endregion

        /// <summary>
        /// LaunchViewModel init
        /// </summary>
        /// <param name="navigationStore">current instance of NavigationStore</param>
        public LaunchViewModel(NavigationStore navigationStore)
        {
            // Set LoginViewModel like CurrentViewModel
            NavigateLoginView = CommandFromFunction(x => navigationStore.CurrentViewModel = new LoginViewModel(navigationStore));
            // Set RegistrationViewModel like CurrentViewModel
            NavigateRegistrationView = CommandFromFunction(x => navigationStore.CurrentViewModel = new RegistrationViewModel(navigationStore));
        }
    }
}