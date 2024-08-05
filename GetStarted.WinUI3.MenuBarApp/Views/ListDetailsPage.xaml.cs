using CommunityToolkit.WinUI.UI.Controls;

using GetStarted.WinUI3.MenuBarApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GetStarted.WinUI3.MenuBarApp.Views;

public sealed partial class ListDetailsPage : Page
{
    public ListDetailsViewModel ViewModel
    {
        get;
    }

    public ListDetailsPage()
    {
        ViewModel = App.GetService<ListDetailsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
