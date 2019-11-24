using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryApp.Core.ViewModels
{
    public class DeliveryAddressViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public DeliveryAddressViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
        }
        public IMvxCommand CloseCommand { get; private set; }
    }
}
