using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace School_Mangement_System
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (IsValidUser(username, password))
            {
                Navigation.PushAsync(new MainPage());
            }

            else
            {
                DisplayAlert("Login Failed", "Invalid username or password. Please try again.", "OK");
            }
        }

        private bool IsValidUser(string username, string password) 
        {
            return username == "admin" && password == "password";
        }
    }

}
