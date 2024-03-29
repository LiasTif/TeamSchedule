﻿using System;
using System.Globalization;
using System.Windows.Data;
using TeamScheduleApp.ViewModels.UserControls;

namespace TeamScheduleApp.Conventers
{
    /// <summary>
    /// create UserInitElementsViewModel and set it to parent VM
    /// </summary>
    public class GetUserInitElementsVM : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            UserInitElementsViewModel userInitElementsVM = null;

            if (value is RegistrationViewModel registrationVM)
            {
                userInitElementsVM = new UserInitElementsViewModel(registrationVM.NavigationStore)
                {
                    ParentViewModel = registrationVM
                };
                registrationVM.UserInitElementsViewModel = userInitElementsVM;
            }
            else if (value is LoginViewModel loginVM)
            {
                userInitElementsVM = new UserInitElementsViewModel(loginVM.NavigationStore)
                {
                    ParentViewModel = loginVM
                };
                loginVM.UserInitElementsViewModel = userInitElementsVM;
            }
            
            return userInitElementsVM ?? throw new Exception(); // if userInitElementsVM are null throw Exception
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
