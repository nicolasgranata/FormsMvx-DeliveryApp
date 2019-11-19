using DeliveryApp.Core.Models;
using MvvmCross.ViewModels;

namespace DeliveryApp.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            MySuggestions = new MvxObservableCollection<Suggestion>();
            MySuggestions.Add(new Suggestion { Image="burguer.png", Title = "Hamburguesa con queso y papas", Price = "$200" });
            MySuggestions.Add(new Suggestion { Image = "sushi.png", Title = "Sushi Take away", Price = "$200" });
            MySuggestions.Add(new Suggestion { Image = "pizza.png", Title = "Pizza grande", Price = "$200" });
            MySuggestions.Add(new Suggestion { Image = "ice_cream.png", Title = "Helado por kilo", Price = "$200" });
            MySuggestions.Add(new Suggestion { Image = "vegetables.png", Title = "Esto es un titulo 5", Price = "$200" });
        }

        public MvxObservableCollection<Suggestion> MySuggestions { get; set; }
    }
}
