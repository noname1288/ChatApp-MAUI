using ChatAppUI.Views;

namespace ChatAppUI;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}