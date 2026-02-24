namespace ChatAppUI.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route);
    Task NavigateToAsync(string route, Dictionary<string, object> parameters);
    Task GoBackAsync();
}
