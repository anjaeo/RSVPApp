using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnjaeRSVP.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnjaeRSVP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            userDAL dal = new userDAL();
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorLbl.Text = "Please enter your first name.";
            } else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorLbl.Text = "Please enter your last name.";
            }  else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorLbl.Text = "Please enter your email address.";
            } else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorLbl.Text = "Please enter your phone number.";
             } 
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorLbl.Text = "Please enter a username.";
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorLbl.Text = "Please enter a password.";
            }
            else {

                Users user = new Users
                {
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    email = txtEmail.Text,
                    phone = txtPhone.Text,
                    username = txtUsername.Text,
                    password = txtPassword.Text
                };

                userDAL dal = new userDAL();
                dal.AddUser(user);

                await Navigation.PushAsync(new HomePage(txtUsername.Text, txtPassword.Text));
            }
        }

        private void RegisterCancelBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}