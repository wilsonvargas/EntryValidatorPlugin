using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryValidator.FormsPlugin.Abstractions.ViewModels
{
    public class EmailValidatorViewModel : ViewModelBase
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

    }
}
