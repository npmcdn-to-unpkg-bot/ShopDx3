﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ShopDx3.ViewModels;

namespace ShopDx3.ApplicationServices
{
    public interface IOrderService
    {
        Task<OrderVm> GetOrderByIdAsync(string id);
        Task<IEnumerable<OrderVm>> GetAllOrdersAsync();
        Task<IEnumerable<OrderVm>> GetAllCurrentOrdersAsync();
        Task<IEnumerable<OrderVm>> GetAllPastOrdersAsync();
        Task<IEnumerable<OrderVm>> GetAllOrdersByServiceTypeAsync(string type);
        Task<OrderVm> PlaceOrderAsync(OrderVm order);
        IDictionary<string, string> GetServiceOptions();
        Task<long> CountPendingOrders();
    }
}