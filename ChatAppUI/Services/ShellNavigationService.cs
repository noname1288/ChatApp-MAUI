namespace ChatAppUI.Services;

public class ShellNavigationService : INavigationService
{
    public Task NavigateToAsync(string route)
    {
        return Shell.Current.GoToAsync(route);
    }

    public Task NavigateToAsync(string route, Dictionary<string, object> parameters)
    {
        return Shell.Current.GoToAsync(route, parameters);
    }

    public Task GoBackAsync()
    {
        return Shell.Current.GoToAsync("..");
    }
}