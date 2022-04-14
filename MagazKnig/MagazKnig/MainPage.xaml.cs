using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagazKnig
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void AuthorizationPageBTN_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorizationPage());
        }
    }
}
