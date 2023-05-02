using System.Windows;
using System.Windows.Controls;

namespace Kakao.LayoutSupport.UI.Units
{
    public class PlaceHolderPasswordBox : TextBox
    {
        public static readonly DependencyProperty PlaceHolderTextProperty = DependencyProperty.Register(nameof(PlaceHolderText), typeof(string), typeof(PlaceHolderPasswordBox), new PropertyMetadata(""));

        static PlaceHolderPasswordBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlaceHolderPasswordBox), new FrameworkPropertyMetadata(typeof(PlaceHolderPasswordBox)));
        }

        public string PlaceHolderText
        {
            get { return (string)GetValue(PlaceHolderTextProperty); }
            set { SetValue(PlaceHolderTextProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();


            if (GetTemplateChild("PART_PasswordBox") is PasswordBox pwd)
            {
                pwd.PasswordChanged += Pwd_PasswordChanged;
            }
        }

        private void Pwd_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox pwd)
            {
                SetValue(TextProperty, pwd.Password);
            }
        }

        private void CustomPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == this)
            {
                PasswordBox passwordBox = GetTemplateChild("PART_PasswordBox") as PasswordBox;
                if (passwordBox != null)
                {
                    passwordBox.Focus();
                }
            }
        }
    }
}
