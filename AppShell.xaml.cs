using mauiProject.Views;

namespace mauiProject;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BrandList), typeof(BrandList));
		Routing.RegisterRoute(nameof(BrandDetail), typeof(BrandDetail));
	}
}
