using GetStarted.WinUI3.MenuBarApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GetStarted.WinUI3.MenuBarApp.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
