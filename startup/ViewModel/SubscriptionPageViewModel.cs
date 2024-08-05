using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace startup
{
    public class SubscriptionPageViewModel : BaseViewModel
    {
        public ICommand SelectBasicSubscriptionCommand { get; }
        public ICommand SelectProSubscriptionCommand { get; }
        public ICommand SelectPremiumSubscriptionCommand { get; }

        public SubscriptionPageViewModel()
        {
            SelectBasicSubscriptionCommand = new Command(OnSelectBasicSubscription);
            SelectProSubscriptionCommand = new Command(OnSelectProSubscription);
            SelectPremiumSubscriptionCommand = new Command(OnSelectPremiumSubscription);
        }

        private async void OnSelectBasicSubscription()
        {
            
        }

        private async void OnSelectProSubscription()
        {
            
        }

        private async void OnSelectPremiumSubscription()
        {
            
        }
    }
}
