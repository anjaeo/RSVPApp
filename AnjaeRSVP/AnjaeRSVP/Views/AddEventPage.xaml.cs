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
    public partial class AddEventPage : ContentPage
    {
        public AddEventPage()
        {
            InitializeComponent();
        }

        private async void AddEventCancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventsList());
        }
        private async void AddEventButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hostName.Text))
            {
                errorLbl.Text = "Please enter the host's name.";
            }
            else if (string.IsNullOrEmpty(eventName.Text))
            {
                errorLbl.Text = "Please enter the event;s name.";
            }
            else if (string.IsNullOrEmpty(eventAddress.Text))
            {
                errorLbl.Text = "Please enter the event's address.";
            }
            else if (string.IsNullOrEmpty(eventDate.Text))
            {
                errorLbl.Text = "Please enter the event's date.";
            }
            else if (string.IsNullOrEmpty(eventTime.Text))
            {
                errorLbl.Text = "Please enter the event's time.";
            }
            else if (string.IsNullOrEmpty(eventDeadline.Text))
            {
                errorLbl.Text = "Please enter the event's RSVP deadline.";
            }
            else
            {
                await Navigation.PushAsync(new AcctPage());
            }
        }
    }
}