using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DeliveryApp.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowHomeCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<HomeViewModel>());
        }

        public IMvxCommand ShowHomeCommand { get; private set; }
        public IMvxCommand ShowMyOrdersCommand { get; private set; }
        public IMvxCommand ShowMyAddressesCommand { get; private set; }
    }
}
