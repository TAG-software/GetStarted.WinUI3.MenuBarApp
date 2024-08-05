namespace GetStarted.WinUI3.MenuBarApp.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
