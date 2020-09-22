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
    public partial class EventsList : ContentPage
    {
        public EventsList()
        {
            InitializeComponent();
        }

        private async void AddEventButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEventPage());
        }

        private async void EventDetailsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails(eventName.Text));
        }

        private async void RSVPButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RsvpPage(eventName.Text));
        }
    }
}