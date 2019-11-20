using System.Collections.Generic;
using System.Threading.Tasks;
using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;

namespace DeliveryApp.Core.Services
{
    public class SuggestionService : ISuggestionService
    {
        public async Task<IEnumerable<Suggestion>> GetSuggestions()
        {
            var suggestions = new List<Suggestion>
            {
                new Suggestion { Image = "burguer.png", Title = "Hamburguesa con queso y papas", Price = "$200" },
                new Suggestion { Image = "sushi.png", Title = "Sushi Take away", Price = "$200" },
                new Suggestion { Image = "pizza.png", Title = "Pizza grande", Price = "$200" },
                new Suggestion { Image = "ice_cream.png", Title = "Helado por kilo", Price = "$200" },
                new Suggestion { Image = "vegetables.png", Title = "Esto es un titulo 5", Price = "$200" }
            };

            return await Task.FromResult(suggestions);
        }
    }
}
