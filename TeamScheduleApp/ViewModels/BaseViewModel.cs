using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System;

namespace TeamScheduleApp.ViewModels
{
    /// <summary>
    /// INotifyPropertyChanged realization class
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Property Helpers
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Helper metod to fast set a params for property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">referense to field</param>
        /// <param name="value">value</param>
        /// <param name="propertyName">name of our property</param>
        /// <returns>is params setted</returns>
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;

            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
        #region Command Helpers
        internal RelayCommand CommandFromFunction(Action<object> func)
        {
            return new RelayCommand(func);
        }
        #endregion
    }

    /// <summary>
    /// Relay for commands class
    /// </summary>
    class RelayCommand : ICommand
    {
        private readonly Action<object> _action;

        public RelayCommand(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) => true;
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) => _action(parameter);
    }
}
