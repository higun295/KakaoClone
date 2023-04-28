﻿using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace Kakao.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            // 어떻게하든 여기에서 LoginContent -> FriendsContent로 바꿔치기 하겠따
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable friendsContent = _containerProvider.Resolve<IViewable>("FriendsContent");

            if (!mainRegion.Views.Contains(friendsContent))
            {
                mainRegion.Add(friendsContent);
            }
            mainRegion.Activate(friendsContent);
        }
    }
}
