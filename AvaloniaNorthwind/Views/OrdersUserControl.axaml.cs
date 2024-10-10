using Avalonia.Controls;
using AvaloniaNorthwind.ViewModels;

namespace AvaloniaNorthwind;

public partial class OrdersUserControl : UserControl
{
    public OrdersUserControl()
    {
        InitializeComponent();
        DataContext = new OrdersUserControlViewModel();
    }
}