using DeliveryApp.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace DeliveryApp.Forms.Views
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Root, WrapInNavigationPage = false, NoHistory = true)]
    public partial class MainPage : MvxMasterDetailPage<MainViewModel>
    {
        private bool _firstTime = true;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (_firstTime)
            {
                ViewModel.ShowMenuViewModelCommand.Execute(null);
                ViewModel.ShowHomeViewModelCommand.Execute(null);

                _firstTime = false;
            }

            base.OnAppearing();
        }
    }
}