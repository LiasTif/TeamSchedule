using System.Collections.Generic;
using System.Windows.Controls;

namespace TeamScheduleApp.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ScheduleMenuView.xaml
    /// </summary>
    public partial class ScheduleMenuView : UserControl
    {
        public ScheduleMenuView()
        {
            InitializeComponent();

            Models.Task task = new Models.Task();
            dgMain.ItemsSource = new List<Models.Task>
            {
                task,
                task
            };
        }
    }
}