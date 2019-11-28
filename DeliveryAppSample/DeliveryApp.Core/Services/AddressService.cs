using DeliveryApp.Core.Models;
using DeliveryApp.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryApp.Core.Services
{
    public class AddressService : IAddressService
    {
        public async Task<IEnumerable<Address>> GetUserAddresses()
        {
            var addresses = new List<Address>
            {
                new Address { Type = "Home", DisplayAddress = "Calle Falsa 123" },
                new Address { Type = "Home", DisplayAddress = "Segurola y Habana" },
            };

            return await Task.FromResult(addresses);
        }
    }
}
