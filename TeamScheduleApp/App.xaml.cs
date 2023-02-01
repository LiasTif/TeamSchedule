using System.Windows;
using TeamScheduleApp.API;
using TeamScheduleApp.ViewModels.UserControls;
using TeamScheduleApp.ViewModels.Windows;
using TeamScheduleApp.Views.Windows;

namespace TeamScheduleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();

            // set current ViewModel(UserControl) to LaunchViewModel
            navigationStore.CurrentViewModel = new LaunchViewModel(navigationStore);

            MainWindow mainWindow = new MainWindow();
            MainWindowViewModel viewModel = new MainWindowViewModel(navigationStore);

            // set ViewModel(DataContext) for MainWindow
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }
}