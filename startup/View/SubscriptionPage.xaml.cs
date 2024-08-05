using Microsoft.Maui.Controls;

namespace startup.Views
{
    public partial class SubscriptionPage : ContentPage
    {
        public SubscriptionPage()
        {
            InitializeComponent();
            BindingContext = new SubscriptionPageViewModel();
        }
    }
}
