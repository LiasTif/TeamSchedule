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
            NavigationStore navigationStore = new NavigationStore { CurrentViewModel = new LaunchViewModel() };

            MainWindow mainWindow = new MainWindow();
            MainWindowViewModel viewModel = new MainWindowViewModel(navigationStore);
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }
}