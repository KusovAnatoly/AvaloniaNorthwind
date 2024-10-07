using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
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