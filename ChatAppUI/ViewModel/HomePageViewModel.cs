using System.Collections.ObjectModel;
using Bumptech.Glide.Load.Model;
using ChatAppUI.Models;
using ChatAppUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatAppUI.ViewModel;

public partial class HomePageViewModel : ObservableObject
{
    private readonly MessageService _messageService;

    [ObservableProperty] private ObservableCollection<User> _users;
    [ObservableProperty] private ObservableCollection<Message> _messages;

    public HomePageViewModel(MessageService messageService)
    {
        _messageService = messageService;

        LoadData();
    }

    private void LoadData()
    {
        Users = new ObservableCollection<User>(_messageService.GetUsers());
        Messages = new ObservableCollection<Message>(_messageService.GetChats());
    }
}
