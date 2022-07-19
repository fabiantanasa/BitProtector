using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BitProtector_DAM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "admin")
            {
                Navigation.PushAsync(new AdminPage());
            }
            else
            {
                DisplayAlert("Login eșuat", "Adresa de e-mail sau parola sunt incorecte.", "Ok");
            }
        }


    }
}