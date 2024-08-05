using GetStarted.WinUI3.MenuBarApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GetStarted.WinUI3.MenuBarApp.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
