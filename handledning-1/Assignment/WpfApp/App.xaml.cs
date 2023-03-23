using System.Windows;
using WpfApp.Navigation;
using WpfApp.Services;
using WpfApp.ViewModels;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly UserService _userService = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            var currentUser = _userService.GetAsync(x => x.Email == "hans@domain.com");

            var navigationStore = new NavigationStore() { UserId = currentUser.Id };
            navigationStore.CurrentViewModel = new ActiveCasesViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
