﻿using DeliveryApp.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryApp.Core.Services.Interfaces
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetUserAddresses();
    }
}
