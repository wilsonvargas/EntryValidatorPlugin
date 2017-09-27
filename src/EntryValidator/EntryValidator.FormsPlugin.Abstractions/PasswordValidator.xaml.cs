using EntryValidator.FormsPlugin.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntryValidator.FormsPlugin.Abstractions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PasswordValidator : ContentView
	{
		public PasswordValidator()
		{
			InitializeComponent();
		}

        public Security Security
        {
            get { return (Security) base.GetValue(SecurityProperty); }
            set { base.SetValue(SecurityProperty, value); }
        }

        private static BindableProperty SecurityProperty = BindableProperty.Create(
                                                         propertyName: "Security",
                                                         returnType: typeof(Security),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: Security.Alphanumeric,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: SecurityPropertyChanged);


        private static void SecurityPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.securityValidator.Security = newValue.ToString();
        }
    }
}