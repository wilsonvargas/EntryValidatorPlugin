using EntryValidator.FormsPlugin.Abstractions.Behaviors;
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
    public partial class CompareValidator : ContentView
    {
        public CompareValidator()
        {
            InitializeComponent();
        }

        #region BindablePropertiesFirsEntry
        public string FirstEntryText
        {
            get { return base.GetValue(FirstEntryTextProperty).ToString(); }
            set { base.SetValue(FirstEntryTextProperty, value); }
        }

        private static BindableProperty FirstEntryTextProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryText",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryTextPropertyChanged);


        private static void FirstEntryTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.Text = newValue.ToString();
        }

        public string FirstEntryPlaceHolder
        {
            get { return base.GetValue(FirstEntryPlaceHolderProperty).ToString(); }
            set { base.SetValue(FirstEntryPlaceHolderProperty, value); }
        }

        private static BindableProperty FirstEntryPlaceHolderProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryPlaceHolder",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: "Email",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryPlaceHolderPropertyChanged);


        private static void FirstEntryPlaceHolderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.Placeholder = newValue.ToString();
        }

        public string MessageError
        {
            get { return base.GetValue(MessageErrorProperty).ToString(); }
            set { base.SetValue(MessageErrorProperty, value); }
        }

        private static BindableProperty MessageErrorProperty = BindableProperty.Create(
                                                         propertyName: "MessageError",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: "Enter same value as above.",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: MessageErrorPropertyChanged);


        private static void MessageErrorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.messagaError.Text = newValue.ToString();
        }

        public bool ShowMessageError
        {
            get { return Convert.ToBoolean(GetValue(ShowMessageErrorProperty).ToString()); }
            set { base.SetValue(ShowMessageErrorProperty, value); }
        }

        private static BindableProperty ShowMessageErrorProperty = BindableProperty.Create(
                                                         propertyName: "ShowMessageError",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: true,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ShowMessageErrorPropertyChanged);


        private static void ShowMessageErrorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
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
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: Color.Red,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: ErrorMessageColorPropertyChanged);


        private static void ErrorMessageColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.messagaError.TextColor = (Color)newValue;
        }


        public LayoutOptions FirstEntryHorizontalOptions
        {
            get { return (LayoutOptions)GetValue(FirstEntryHorizontalOptionsProperty); }
            set { base.SetValue(FirstEntryHorizontalOptionsProperty, value); }
        }

        private static BindableProperty FirstEntryHorizontalOptionsProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryHorizontalOptions",
                                                         returnType: typeof(LayoutOptions),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: LayoutOptions.FillAndExpand,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryHorizontalOptionsPropertyChanged);


        private static void FirstEntryHorizontalOptionsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.HorizontalOptions = (LayoutOptions)newValue;
        }

        public Keyboard FirstEntryKeyboard
        {
            get { return (Keyboard)GetValue(FirstEntryKeyboardProperty); }
            set { base.SetValue(FirstEntryKeyboardProperty, value); }
        }

        private static BindableProperty FirstEntryKeyboardProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryKeyboard",
                                                         returnType: typeof(Keyboard),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: Keyboard.Default,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryKeyboardPropertyChanged);


        private static void FirstEntryKeyboardPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.Keyboard = (Keyboard)newValue;
        }


        public bool FirstEntryIsPassword
        {
            get { return (bool)GetValue(FirstEntryIsPasswordProperty); }
            set { base.SetValue(FirstEntryIsPasswordProperty, value); }
        }

        private static BindableProperty FirstEntryIsPasswordProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryIsPassword",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: false,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryIsPasswordPropertyChanged);


        private static void FirstEntryIsPasswordPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.IsPassword = (bool)newValue;
        }

        public bool FirstEntryEmailValidator
        {
            get { return (bool)GetValue(FirstEntryEmailValidatorProperty); }
            set { base.SetValue(FirstEntryEmailValidatorProperty, value); }
        }

        private static BindableProperty FirstEntryEmailValidatorProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryEmailValidator",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: false,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: FirstEntryEmailValidatorPropertyChanged);


        private static void FirstEntryEmailValidatorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.Behaviors.Add(new EmailValidatorBehavior());
        }


        #endregion

        #region BindablePropertiesCompareEntry
        public string CompareEntryText
        {
            get { return base.GetValue(CompareEntryTextProperty).ToString(); }
            set { base.SetValue(CompareEntryTextProperty, value); }
        }

        private static BindableProperty CompareEntryTextProperty = BindableProperty.Create(
                                                         propertyName: "CompareEntryText",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryTextPropertyChanged);


        private static void CompareEntryTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.compareText.Text = newValue.ToString();
        }

        public string CompareEntryPlaceHolder
        {
            get { return base.GetValue(CompareEntryPlaceHolderProperty).ToString(); }
            set { base.SetValue(CompareEntryPlaceHolderProperty, value); }
        }

        private static BindableProperty CompareEntryPlaceHolderProperty = BindableProperty.Create(
                                                         propertyName: "CompareEntryPlaceHolder",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: "Enter same as above.",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryPlaceHolderPropertyChanged);


        private static void CompareEntryPlaceHolderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.compareText.Placeholder = newValue.ToString();
        }    


        public LayoutOptions CompareEntryHorizontalOptions
        {
            get { return (LayoutOptions)GetValue(CompareEntryHorizontalOptionsProperty); }
            set { base.SetValue(CompareEntryHorizontalOptionsProperty, value); }
        }

        private static BindableProperty CompareEntryHorizontalOptionsProperty = BindableProperty.Create(
                                                         propertyName: "CompareEntryHorizontalOptions",
                                                         returnType: typeof(LayoutOptions),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: LayoutOptions.FillAndExpand,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryHorizontalOptionsPropertyChanged);


        private static void CompareEntryHorizontalOptionsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.compareText.HorizontalOptions = (LayoutOptions)newValue;
        }

        public Keyboard CompareEntryKeyboard
        {
            get { return (Keyboard)GetValue(CompareEntryKeyboardProperty); }
            set { base.SetValue(CompareEntryKeyboardProperty, value); }
        }

        private static BindableProperty CompareEntryKeyboardProperty = BindableProperty.Create(
                                                         propertyName: "FirstEntryKeyboard",
                                                         returnType: typeof(Keyboard),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: Keyboard.Default,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryKeyboardPropertyChanged);


        private static void CompareEntryKeyboardPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.firstText.Keyboard = (Keyboard)newValue;
        }


        public bool CompareEntryIsPassword
        {
            get { return (bool)GetValue(CompareEntryIsPasswordProperty); }
            set { base.SetValue(CompareEntryIsPasswordProperty, value); }
        }

        private static BindableProperty CompareEntryIsPasswordProperty = BindableProperty.Create(
                                                         propertyName: "CompareEntryIsPassword",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: false,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryIsPasswordPropertyChanged);


        private static void CompareEntryIsPasswordPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.compareText.IsPassword = (bool)newValue;
        }


        public bool CompareEntryEmailValidator
        {
            get { return (bool)GetValue(CompareEntryEmailValidatorProperty); }
            set { base.SetValue(CompareEntryEmailValidatorProperty, value); }
        }

        private static BindableProperty CompareEntryEmailValidatorProperty = BindableProperty.Create(
                                                         propertyName: "CompareEntryEmailValidator",
                                                         returnType: typeof(bool),
                                                         declaringType: typeof(CompareValidator),
                                                         defaultValue: false,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: CompareEntryEmailValidatorPropertyChanged);


        private static void CompareEntryEmailValidatorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CompareValidator)bindable;
            control.compareText.Behaviors.Add(new EmailValidatorBehavior());
        }

        #endregion
    }
}