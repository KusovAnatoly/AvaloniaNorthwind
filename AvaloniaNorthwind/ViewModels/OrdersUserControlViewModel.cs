using AvaloniaNorthwind.Data;
using AvaloniaNorthwind.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AvaloniaNorthwind.ViewModels;

public partial class OrdersUserControlViewModel : ViewModelBase
{

    [ObservableProperty]
    private ObservableCollection<Order> _orders;

    [ObservableProperty]
    private IAsyncRelayCommand _asyncLoadOrdersCommand;

    public OrdersUserControlViewModel()
    {
        AsyncLoadOrdersCommand = new AsyncRelayCommand(LoadOrdersAsync);
        Task.Run(LoadOrdersAsync);
    }


    private async Task LoadOrdersAsync()
    {
        using (var dbContext = new NorthwindContext())
        {
            var orders = await dbContext.Orders.Include(x => x.OrderDetails).ThenInclude(x => x.Product).ToListAsync();

            Orders = new ObservableCollection<Order>(orders);
        }
    }
}
