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
        private readonly INewsService _newsService;
        private readonly IMvxNavigationService _navigationService;

        public HomeViewModel(ISuggestionService suggestionService, INewsService newsService,
                             IMvxNavigationService navigationService)
        {
            _suggestionService = suggestionService;
            _newsService = newsService;
            _navigationService = navigationService;

            Suggestions = new MvxObservableCollection<Suggestion>();
            News = new MvxObservableCollection<News>();

            ShowDeliveryAddressCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<DeliveryAddressViewModel>());
        }

        public override Task Initialize()
        {
            LoadSuggestionsTask = MvxNotifyTask.Create(LoadSuggestions);
            LoadNewsTaks = MvxNotifyTask.Create(LoadNews);

            return Task.FromResult(0);
        }

        public IMvxAsyncCommand ShowDeliveryAddressCommand { get; private set; }

        public MvxNotifyTask LoadSuggestionsTask { get; private set; }
        public MvxNotifyTask LoadNewsTaks { get; private set; }

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

        private MvxObservableCollection<News> _news;
        public MvxObservableCollection<News> News
        {
            get
            {
                return _news;
            }
            set
            {
                _news = value;
                RaisePropertyChanged(() => News);
            }
        }

        private async Task LoadSuggestions()
        {
            var result = await _suggestionService.GetSuggestions();

            Suggestions.AddRange(result);
        }

        private async Task LoadNews()
        {
            var result = await _newsService.GetNews();

            News.AddRange(result);
        }
    }
}
