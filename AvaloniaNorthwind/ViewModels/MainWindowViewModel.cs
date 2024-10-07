using Avalonia.Controls;
using Avalonia.Layout;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace AvaloniaNorthwind.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private UserControl _currentView;

    [RelayCommand]
    private void OpenView(string name)
    {
        switch (name)
        {
            case "Orders":
                CurrentView = new OrdersUserControl();
                break;
            case "Products":
                CurrentView = new OrdersUserControl();
                break;
            case "Customers":
                CurrentView = new OrdersUserControl();
                break;
            case "Supplier":
                CurrentView = new OrdersUserControl();
                break;
            case "Shippers":
                CurrentView = new OrdersUserControl();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(name), $"Not expected direction value: {name}");
        }
    }

    public MainWindowViewModel()
    {
        OpenView("Orders");
    }
}
