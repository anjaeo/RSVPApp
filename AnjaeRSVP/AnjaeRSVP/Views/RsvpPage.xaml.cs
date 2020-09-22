using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnjaeRSVP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RsvpPage : ContentPage
    {
        public RsvpPage(string title)
        {
            InitializeComponent();

            eventName.Text = title;
        }
        
        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                errorLbl.Text = "Please enter your name.";
            }
            else if (string.IsNullOrEmpty(email.Text))
            {
                errorLbl.Text = "Please enter your email address.";
            }
            else if (string.IsNullOrEmpty(phone.Text))
            {
                errorLbl.Text = "Please enter your phone number.";
            } else
            {
                await Navigation.PushAsync(new AcctPage());
            }
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails(eventName.Text));
        }
    }
}

