using System.Collections.ObjectModel;
using ChatAppUI.Models;
using ChatAppUI.Services;
using ChatAppUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChatAppUI.ViewModel;

public partial class HomePageViewModel : ObservableObject
{
    private readonly INavigationService _navigation;
    private readonly MessageService _messageService;

    [ObservableProperty] private ObservableCollection<User> _users;
    [ObservableProperty] private ObservableCollection<Message> _messages;

    public HomePageViewModel(INavigationService navigation, MessageService messageService)
    {
        _navigation = navigation;
        _messageService = messageService;

        LoadData();
    }

    private void LoadData()
    {
        Users = new ObservableCollection<User>(_messageService.GetUsers());
        Messages = new ObservableCollection<Message>(_messageService.GetChats());
    }

    [RelayCommand]
    private async Task GoToChatDetail(Message recentMessage)
    {
        if (recentMessage == null)
            return;

        await _navigation.NavigateToAsync(nameof(DetailPage),
            new Dictionary<string, object>
            {
                {
                    "RecentMessage", recentMessage
                }
            }
        );
    }
}
