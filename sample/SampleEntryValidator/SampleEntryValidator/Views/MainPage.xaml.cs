using SampleEntryValidator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleEntryValidator.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Values",
                "Name: " + entryEmail.Text + Environment.NewLine, "Oki Doki");
        }
    }
}
