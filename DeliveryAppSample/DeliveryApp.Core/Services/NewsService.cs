using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Core.Services
{
    public class NewsService : INewsService
    {
        public async Task<IEnumerable<News>> GetNews()
        {
            var news = new List<News>
            {
                new News { Title = "Nuevo Bar Palermo", Image = "bar.png" },
                new News { Title = "Cafe Latte 2 x 1", Image = "cafe.png" },
                new News { Title = "Fresco y Delicioso", Image = "appetizer.png" },
                new News { Title = "Disfruta tu Brunch", Image = "restaurant.png" },
            };

            return await Task.FromResult(news);
        }
    }
}
