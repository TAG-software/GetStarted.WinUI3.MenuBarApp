namespace GetStarted.WinUI3.MenuBarApp.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
