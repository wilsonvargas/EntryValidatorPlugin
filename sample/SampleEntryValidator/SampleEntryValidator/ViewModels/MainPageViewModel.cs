using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleEntryValidator.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        #region Properties
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _creditCard;

        public string CreditCard
        {
            get { return _creditCard; }
            set { SetProperty(ref _creditCard, value); }
        }

        private string _textCompared;

        public string TextCompared
        {
            get { return _textCompared; }
            set { SetProperty(ref _textCompared, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        public ICommand RegisterCommand { get; set; }

        public MainPageViewModel()
        {
            RegisterCommand = new Command(Register);
        }

        private async void Register()
        {
            await App.Current.MainPage.DisplayAlert("Values",
                "Name: " + Name + Environment.NewLine +
                "Credit Card: " + CreditCard + Environment.NewLine +
                "Text Compared: " + TextCompared + Environment.NewLine +
                "Email: " + Email + Environment.NewLine +
                "Password: " + Password + Environment.NewLine, "Oki Doki");
        }

    }
}
