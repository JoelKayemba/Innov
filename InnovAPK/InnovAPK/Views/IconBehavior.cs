using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InnovAPK.Views
{
    public class IconBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(IconBehavior), default(string));

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            var layout = new StackLayout { Orientation = StackOrientation.Horizontal };
            var icon = new Image { Source = Icon, HeightRequest = 20, WidthRequest = 20, VerticalOptions = LayoutOptions.Center };
            layout.Children.Add(icon);
            layout.Children.Add(bindable);

            bindable.Parent = layout;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
