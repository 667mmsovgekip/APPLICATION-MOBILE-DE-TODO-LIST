using Microsoft.UI.Xaml;
using ApplicationMobile.Services;
using ApplicationMobile.ViewModels;
using ApplicationMobile.Views;

namespace ApplicationMobile
{
    public partial class App : Application
    {
        private TaskDataService _taskDataService;

        public App()
        {
            InitializeComponent();
            _taskDataService = new TaskDataService();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            var shell = Window.Current.Content as AppShell;
            if (shell == null)
            {
                shell = new AppShell();
                shell.DataContext = new ShellViewModel(_taskDataService);
                Window.Current.Content = shell;
            }

            if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
            {
    
            }

            if (shell.AppFrame.Content == null)
            {
                shell.AppFrame.Navigate(typeof(HomePage));
            }

            Window.Current.Activate();
        }
    }
}
