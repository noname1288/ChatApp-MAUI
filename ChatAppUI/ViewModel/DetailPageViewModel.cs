using ChatAppUI.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatAppUI.ViewModel;

public partial class DetailPageViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private Message message;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("RecentMessage", out var messageObj)
            && messageObj is Message msg)
        {
            Message = msg;
        }
    }
}
