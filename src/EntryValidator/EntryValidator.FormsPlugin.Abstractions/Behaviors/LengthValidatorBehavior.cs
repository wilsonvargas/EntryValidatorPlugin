using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryValidator.FormsPlugin.Abstractions.Behaviors
{
    public class LengthValidatorBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty LengthProperty = BindableProperty.Create("Length", typeof(int), typeof(LengthValidatorBehavior), 0);

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(LengthValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        static readonly BindablePropertyKey IsInvalidPropertyKey = BindableProperty.CreateReadOnly("IsInvalid", typeof(bool), typeof(LengthValidatorBehavior), false);

        public static readonly BindableProperty IsInvalidProperty = IsInvalidPropertyKey.BindableProperty;

        public bool IsInvalid
        {
            get { return (bool)base.GetValue(IsInvalidProperty); }
            private set { base.SetValue(IsInvalidPropertyKey, value); }
        }

        public int Length
        {
            get { return (int)GetValue(LengthProperty); }
            set { SetValue(LengthProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += bindable_TextChanged;
        }

        private void bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (MaxLength != null && MaxLength.HasValue)
            IsInvalid = !(e.NewTextValue.Length > 0 && e.NewTextValue.Length == Length);
            IsValid = (e.NewTextValue.Length > 0 && e.NewTextValue.Length == Length);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= bindable_TextChanged;

        }
    }
}
