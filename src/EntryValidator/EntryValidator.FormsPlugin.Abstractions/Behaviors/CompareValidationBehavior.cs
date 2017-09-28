using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryValidator.FormsPlugin.Abstractions.Behaviors
{
    public class CompareValidationBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(int), typeof(LengthValidatorBehavior), 0);

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(LengthValidatorBehavior), false);

        static readonly BindablePropertyKey IsInvalidPropertyKey = BindableProperty.CreateReadOnly("IsInvalid", typeof(bool), typeof(LengthValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        public static readonly BindableProperty IsInvalidProperty = IsInvalidPropertyKey.BindableProperty;

        public bool IsInvalid
        {
            get { return (bool)base.GetValue(IsInvalidProperty); }
            private set { base.SetValue(IsInvalidPropertyKey, value); }
        }

        public string Text
        {
            get { return GetValue(TextProperty).ToString(); }
            set { SetValue(TextProperty, value); }
        }


        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
            base.OnAttachedTo(bindable);
        }

        void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            bool IsValid = false;
            IsValid = (e.NewTextValue == Text);
            IsInvalid = (e.NewTextValue != Text);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}
