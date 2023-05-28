using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Kakao.Talk.UI.Views
{
    public class KakaoWindow : JamesWindow
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }

        public KakaoWindow()
        {
        }
    }
}