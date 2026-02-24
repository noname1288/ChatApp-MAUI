using ChatAppUI.ViewModel;

namespace ChatAppUI.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}