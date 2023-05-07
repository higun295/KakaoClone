﻿using Kakao.LayoutSupport.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kakao.Friends.Birth.UI.Units
{
    public class BirthdaysBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new BirthdaysBoxItem();
        }
    }
}
