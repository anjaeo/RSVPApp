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
    public partial class EventDetails : ContentPage
    {
        public EventDetails(string title)
        {
            InitializeComponent();

            eventName.Text = title;
            hostName.Text = "Test";
            eventAddress.Text = "123 Test Dr";
            eventDate.Text = "12/31/2020";
            eventTime.Text = "11:59 PM";
            eventMax.Text = "200";
            eventCurrentGuests.Text = "199";
            eventDeadline.Text = "12/30/2020";

        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void RSVPButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RsvpPage(eventName.Text));
        }
    }
}