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
                new Suggestion { Image = "burguer.png", Title = "Hamburguesa completa y papas", 
                                 Price = "$350", Restaurant = "La hamburgueseria"},
                new Suggestion { Image = "sushi.png", Title = "Sushi Take away",
                                 Price = "$600", Restaurant = "Sushi Palermo" },
                new Suggestion { Image = "pizza.png", Title = "Pizza grande", 
                                 Price = "$340", Restaurant = "Pizza Colegiales" },
                new Suggestion { Image = "ice_cream.png", Title = "Helado por kilo",
                                 Price = "$450", Restaurant = "Italia Helados" },
            };

            return await Task.FromResult(suggestions);
        }
    }
}
