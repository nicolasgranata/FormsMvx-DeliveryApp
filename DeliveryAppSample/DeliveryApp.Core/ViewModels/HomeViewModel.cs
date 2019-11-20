using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace DeliveryApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ISuggestionService _suggestionService;
        public HomeViewModel(ISuggestionService suggestionService)
        {
            _suggestionService = suggestionService;

            Suggestions = new MvxObservableCollection<Suggestion>();
        }

        public MvxNotifyTask LoadPlanetsTask { get; private set; }

        public override Task Initialize()
        {
            LoadPlanetsTask = MvxNotifyTask.Create(LoadSuggestions);

            return Task.FromResult(0);
        }

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
