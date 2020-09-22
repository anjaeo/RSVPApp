using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AnjaeRSVP.Model;

namespace AnjaeRSVP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcctPage : ContentPage
    {
        public AcctPage()
        {
            InitializeComponent();
            userDAL user = new userDAL();
            

        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LogoutPage());
        }

        private async void EventDetailsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails(eventName.Text));
        }
    }
}