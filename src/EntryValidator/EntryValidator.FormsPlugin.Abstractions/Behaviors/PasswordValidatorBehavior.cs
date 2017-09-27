using EntryValidator.FormsPlugin.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryValidator.FormsPlugin.Abstractions.Behaviors
{
    public class PasswordValidatorBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty SecurityProperty = BindableProperty.Create("Security", typeof(string), typeof(PasswordValidatorBehavior), 0);

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(PasswordValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        static readonly BindablePropertyKey IsInvalidPropertyKey = BindableProperty.CreateReadOnly("IsInvalid", typeof(bool), typeof(PasswordValidatorBehavior), false);

        public static readonly BindableProperty IsInvalidProperty = IsInvalidPropertyKey.BindableProperty;

        public bool IsInvalid
        {
            get { return (bool)base.GetValue(IsInvalidProperty); }
            private set { base.SetValue(IsInvalidPropertyKey, value); }
        }

        public string Security
        {
            get { return GetValue(SecurityProperty).ToString(); }
            set { SetValue(SecurityProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
        }

        void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            IsValid = (Regex.IsMatch(e.NewTextValue, Security, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            IsInvalid = !(Regex.IsMatch(e.NewTextValue, Security, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;
        }


    }
}
