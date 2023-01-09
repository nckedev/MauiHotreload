namespace MauiHotreload;

public partial class AppShell : Shell
{
	public AppShell()
	{
		Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
		InitializeComponent();
	}
}
