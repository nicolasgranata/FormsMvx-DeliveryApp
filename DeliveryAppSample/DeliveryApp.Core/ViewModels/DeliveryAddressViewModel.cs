using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Core.ViewModels
{
    public class DeliveryAddressViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IAddressService _addressService;

        public DeliveryAddressViewModel(IMvxNavigationService navigationService, IAddressService addressService)
        {
            _navigationService = navigationService;
            _addressService = addressService;

            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));

            AddressList = new MvxObservableCollection<Address>();
        }

        public override Task Initialize()
        {
            LoadUserAddressTask = MvxNotifyTask.Create(LoadUserAddress);

            return Task.FromResult(0);
        }

        public IMvxCommand CloseCommand { get; private set; }

        public MvxNotifyTask LoadUserAddressTask { get; private set; }

        private MvxObservableCollection<Address> _addressList;
        public MvxObservableCollection<Address> AddressList
        {
            get
            {
                return _addressList;
            }
            set
            {
                _addressList = value;
                RaisePropertyChanged(() => AddressList);
            }
        }

        private async Task LoadUserAddress()
        {
            var result = await _addressService.GetUserAddresses();

            AddressList.AddRange(result);
        }
    }
}
