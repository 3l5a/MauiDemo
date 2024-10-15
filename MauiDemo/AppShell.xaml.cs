using MauiDemo.Pages;

namespace MauiDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("Exo7", typeof(Exo7));
    }
}
