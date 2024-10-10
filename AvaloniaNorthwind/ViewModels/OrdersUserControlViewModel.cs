using AvaloniaNorthwind.Data;
using AvaloniaNorthwind.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

    [ObservableProperty]
    private DateTimeOffset? _date;

    [ObservableProperty]
    private DateTimeOffset? _dateRequired;

    [ObservableProperty]
    private bool _canConnect;

    public OrdersUserControlViewModel()
    {
        AsyncLoadOrdersCommand = new AsyncRelayCommand(LoadOrdersAsync);
        Task.Run(LoadOrdersAsync);
    }

    [RelayCommand]
    private void ClearFilters()
    {
        Date = null;
        DateRequired = null;
        SearchQuery = string.Empty;
    }

    private async Task LoadOrdersAsync()
    {
        IsLoading = true;

        using var dbContext = new NorthwindContext();

        CanConnect = await dbContext.Database.CanConnectAsync();

        if (!CanConnect)
        {
            return;
        }

        var orders = await GetFilteredOrders();

        Orders = new ObservableCollection<Order>(orders);

        IsLoading = false;
    }

    private async Task<IEnumerable<Order>> GetFilteredOrders()
    {
        try
        {
            using var dbContext = new NorthwindContext();

            var orders = dbContext.Orders
                                  .Include(x => x.OrderDetails)
                                  .Include(x => x.Customer)
                                  .AsQueryable()
                                  .AsNoTracking();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                orders = orders.Where(order =>
                    order.OrderId.ToString().ToLower().Contains(SearchQuery.ToLower()) ||
                    order.Customer.ContactName.ToLower().Contains(SearchQuery.ToLower()) ||
                    order.Customer.CompanyName.ToLower().Contains(SearchQuery.ToLower()) ||
                    order.Customer.ContactName.ToLower().Contains(SearchQuery.ToLower()) ||
                    order.Customer.Phone.Contains(SearchQuery)
                );
            }

            if (Date is not null)
            {
                orders = orders.Where(order => order.OrderDate == DateOnly.FromDateTime(Date.Value.Date));
            }

            if (DateRequired is not null)
            {
                orders = orders.Where(order => order.RequiredDate == DateOnly.FromDateTime(DateRequired.Value.Date));
            }

            return await orders.ToListAsync();
        }
        catch (Exception exception)
        {
            Debug.WriteLine(exception.Message);
            // In case the connection to the database was not established
            return [];
        }
    }
}
