using AvaloniaNorthwind.Data;
using AvaloniaNorthwind.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AvaloniaNorthwind.ViewModels;

public partial class OrdersUserControlViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<Order> _orders;

    [ObservableProperty]
    private bool _isLoading;

    [ObservableProperty]
    private IAsyncRelayCommand _asyncLoadOrdersCommand;

    [ObservableProperty]
    private string _searchQuery;

    public OrdersUserControlViewModel()
    {
        AsyncLoadOrdersCommand = new AsyncRelayCommand(LoadOrdersAsync);
        Task.Run(LoadOrdersAsync);
    }


    private async Task LoadOrdersAsync()
    {
        IsLoading = true;

        var orders = await GetFilteredOrders();

        IsLoading = false;

        Orders = new ObservableCollection<Order>(orders);
    }

    private async Task<IEnumerable<Order>> GetFilteredOrders()
    {
        using var dbContext = new NorthwindContext();

        if (!string.IsNullOrEmpty(SearchQuery))
        {
            var orders = dbContext.Orders
                                                 .Include(x => x.OrderDetails)
                                                 .Include(x => x.Customer)
                                                 .AsQueryable()
                                                 .AsNoTracking();

            orders = orders.Where(order =>
                order.Customer.ContactName.Contains(SearchQuery) ||
                //order.OrderDate.Value.ToString("dd.MM.yyyy").Contains(SearchQuery) ||
                //order.RequiredDate.Value.ToString("dd.MM.yyyy").Contains(SearchQuery) ||
                order.Customer.CompanyName.Contains(SearchQuery) ||
                order.Customer.ContactName.Contains(SearchQuery) ||
                order.Customer.Phone.Contains(SearchQuery)
            );

            return await orders.ToListAsync();
        }

        return await dbContext.Orders
                        .Include(x => x.OrderDetails)
                        .Include(x => x.Customer)
                        .AsQueryable()
                        .AsNoTracking()
                        .ToListAsync();
    }
}
