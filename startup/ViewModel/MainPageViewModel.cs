using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace startup
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NavigateToRegisterCommand { get; }
        public ICommand NavigateToLoginCommand { get; }

        public MainPageViewModel()
        {
            NavigateToRegisterCommand = new Command(OnNavigateToRegister);
            NavigateToLoginCommand = new Command(OnNavigateToLogin);
        }

        private async void OnNavigateToRegister()
        {
            
            await Shell.Current.GoToAsync("//register");
        }

        private async void OnNavigateToLogin()
        {
            
            await Shell.Current.GoToAsync("//subscription");
        }
    }
}
