namespace mauiProject.Views;

public partial class BrandList : ContentPage
{
	public BrandList()
	{
		InitializeComponent();
	}

    private async void goBack(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}