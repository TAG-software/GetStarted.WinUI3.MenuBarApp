namespace GetStarted.WinUI3.MenuBarApp.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
