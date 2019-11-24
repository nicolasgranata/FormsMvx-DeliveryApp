using DeliveryApp.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace DeliveryApp.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxModalPresentation(WrapInNavigationPage = true)]
    public partial class DeliveryAddressPage : MvxContentPage<DeliveryAddressViewModel>
    {
        public DeliveryAddressPage()
        {
            InitializeComponent();
        }
    }
}