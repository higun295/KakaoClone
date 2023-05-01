using System.Windows;
using System.Windows.Controls;

namespace Kakao.LayoutSupport.UI.Units
{
    public class PlaceHolderTextBox : TextBox
    {
        public static readonly DependencyProperty PlaceHolderTextProperty = DependencyProperty.Register(nameof(PlaceHolderText), typeof(string), typeof(PlaceHolderTextBox), new PropertyMetadata(""));

        static PlaceHolderTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlaceHolderTextBox), new FrameworkPropertyMetadata(typeof(PlaceHolderTextBox)));
        }

        public string PlaceHolderText
        {
            get { return (string)GetValue(PlaceHolderTextProperty); }
            set { SetValue(PlaceHolderTextProperty, value); }
        }
    }
}
