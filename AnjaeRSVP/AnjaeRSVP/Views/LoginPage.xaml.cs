using AnjaeRSVP.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AnjaeRSVP.Model;

namespace AnjaeRSVP
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            userDAL dal = new userDAL();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Username = usernameInput.Text;
            //login.Password = passwordInput.Text;
            string username = "test";
            string password = "test";

            if (!string.IsNullOrEmpty(ErrorLbl.Text))
            {
                ErrorLbl.Text = "";
            }

            if (string.Equals(usernameInput.Text, username))
            {
                if (string.Equals(passwordInput.Text, password))
                {
                    await Navigation.PushAsync(new HomePage(usernameInput.Text, passwordInput.Text));
                }
            }
            else
            {
                ErrorLbl.Text = "Incorrect username or password.";
                usernameInput.Text = string.Empty;
                passwordInput.Text = string.Empty;
            }
            }            
        

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            usernameInput.Text = string.Empty;
            passwordInput.Text = string.Empty;
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void GuestLoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage("guest", "guest"));
        }
    }
}
