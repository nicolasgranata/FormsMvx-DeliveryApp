using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace DeliveryApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ISuggestionService _suggestionService;
        private readonly IMvxNavigationService _navigationService;

        public HomeViewModel(ISuggestionService suggestionService, IMvxNavigationService navigationService)
        {
            _suggestionService = suggestionService;
            _navigationService = navigationService;

            Suggestions = new MvxObservableCollection<Suggestion>();

            ShowDeliveryAddressCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<DeliveryAddressViewModel>());
        }

        public override Task Initialize()
        {
            LoadPlanetsTask = MvxNotifyTask.Create(LoadSuggestions);

            return Task.FromResult(0);
        }

        public IMvxAsyncCommand ShowDeliveryAddressCommand { get; private set; }

        public MvxNotifyTask LoadPlanetsTask { get; private set; }

        private MvxObservableCollection<Suggestion> _suggestions;
        public MvxObservableCollection<Suggestion> Suggestions
        {
            get
            {
                return _suggestions;
            }
            set
            {
                _suggestions = value;
                RaisePropertyChanged(() => Suggestions);
            }
        }

        private async Task LoadSuggestions()
        {
            var result = await _suggestionService.GetSuggestions();

            Suggestions.AddRange(result);
        }
    }
}
