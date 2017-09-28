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
		public PasswordValidator ()
		{
			InitializeComponent ();
		}

        #region BindableProperties
        public string Text
        {
            get { return base.GetValue(TextProperty).ToString(); }
            set { base.SetValue(TextProperty, value); }
        }

        private static BindableProperty TextProperty = BindableProperty.Create(
                                                         propertyName: "Text",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: TextPropertyChanged);



        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.password.Text = newValue.ToString();
        }

        public string PlaceHolder
        {
            get { return base.GetValue(PlaceHolderProperty).ToString(); }
            set { base.SetValue(PlaceHolderProperty, value); }
        }

        private static BindableProperty PlaceHolderProperty = BindableProperty.Create(
                                                         propertyName: "PlaceHolder",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: "Password",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: PlaceHolderPropertyChanged);


        private static void PlaceHolderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.password.Placeholder = newValue.ToString();
        }

        public string MessageError
        {
            get { return base.GetValue(MessageErrorProperty).ToString(); }
            set { base.SetValue(MessageErrorProperty, value); }
        }

        private static BindableProperty MessageErrorProperty = BindableProperty.Create(
                                                         propertyName: "MessageError",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: "Enter a valid value.",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: MessageErrorPropertyChanged);


        private static void MessageErrorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.messagaError.Text = newValue.ToString();
        }

        public bool ShowIcon
        {
            get { return Convert.ToBoolean(GetValue(ShowIconProperty).ToString()); }
            set { base.SetValue(ShowIconProperty, value); }
        }

        private static BindableProperty ShowIconProperty = BindableProperty.Create(
                                                         propertyName: "ShowIcon",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowIconPropertyChanged);


        private static void ShowIconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.image.IsVisible = Convert.ToBoolean(newValue.ToString());
        }

        public bool ShowMessageError
        {
            get { return Convert.ToBoolean(GetValue(ShowMessageErrorProperty).ToString()); }
            set { base.SetValue(ShowMessageErrorProperty, value); }
        }

        private static BindableProperty ShowMessageErrorProperty = BindableProperty.Create(
                                                         propertyName: "ShowMessageError",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowMessageErrorPropertyChanged);


        private static void ShowMessageErrorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.error.IsVisible = Convert.ToBoolean(newValue.ToString());
        }

        public Color ErrorMessageColor
        {
            get { return (Color)GetValue(ErrorMessageColorProperty); }
            set { base.SetValue(ErrorMessageColorProperty, value); }
        }

        private static BindableProperty ErrorMessageColorProperty = BindableProperty.Create(
                                                         propertyName: "ErrorMessageColor",
                                                         returnType: typeof(Color),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: Color.Red,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ErrorMessageColorPropertyChanged);


        private static void ErrorMessageColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.messagaError.TextColor = (Color)newValue;
        }


        public LayoutOptions HorizontalOptions
        {
            get { return (LayoutOptions)GetValue(HorizontalOptionsProperty); }
            set { base.SetValue(HorizontalOptionsProperty, value); }
        }

        private static BindableProperty HorizontalOptionsProperty = BindableProperty.Create(
                                                         propertyName: "HorizontalOptions",
                                                         returnType: typeof(LayoutOptions),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: LayoutOptions.FillAndExpand,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: HorizontalOptionsPropertyChanged);


        private static void HorizontalOptionsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.password.HorizontalOptions = (LayoutOptions)newValue;
        }

        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set { base.SetValue(IsPasswordProperty, value); }
        }

        private static BindableProperty IsPasswordProperty = BindableProperty.Create(
                                                         propertyName: "IsPassword",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(PasswordValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: IsPasswordPropertyChanged);


        private static void IsPasswordPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (PasswordValidator)bindable;
            control.password.IsPassword = (bool)newValue;
        }

        #endregion
    }
}