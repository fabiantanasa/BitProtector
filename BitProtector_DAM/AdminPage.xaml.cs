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
    public partial class AdminPage
        : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetContactsAsync();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(emailEntry.Text) && !string.IsNullOrWhiteSpace(numberEntry.Text))
            {
                await App.Database.SaveContactAsync(new Contact
                {
                    Name = nameEntry.Text,
                    Email = emailEntry.Text,
                    Number = numberEntry.Text,
                    Subscribed = subscribed.IsChecked
                });

                nameEntry.Text = emailEntry.Text = numberEntry.Text = string.Empty;
                subscribed.IsChecked = false; 


                collectionView.ItemsSource = await
                 App.Database.GetContactsAsync();

            }
        }

    }
}