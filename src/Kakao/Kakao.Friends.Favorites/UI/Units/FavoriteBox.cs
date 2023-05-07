using Kakao.LayoutSupport.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kakao.Friends.Favorites.UI.Units
{
    public class FavoriteBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FavoriteBoxItem();
        }
    }
}
