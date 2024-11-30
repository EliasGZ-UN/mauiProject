using mauiProject.Models;
using mauiProject.Services;
using mauiProject.Views;

namespace mauiProject;

public partial class MainPage : ContentPage
{
	int count = 0;
	private readonly IBrandService _brandService;

	public MainPage(IBrandService brandService)
	{
		InitializeComponent();

		_brandService = brandService;

		GetBrandList();
	}

	private async void GetBrandList()
	{
		List<BrandModel> brands = await _brandService.GetList();

		listForBrands.ItemsSource = brands;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void goToBrandsList(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(BrandList));
    }

    private async void listForBrands_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		//await DisplayAlert("Probando ItemSelected", "El id seleccionado es: " + ((BrandModel)listForBrands.SelectedItem).id, "OK");
    }

    private async void goToBrandDetail(object sender, EventArgs e)
    {
		if(listForBrands.SelectedItem != null)
		{
			var brandId = ((BrandModel)listForBrands.SelectedItem).id;
			var brandDetailPage = new BrandDetail(_brandService)
			{
				id = brandId
			};

			await Navigation.PushAsync(brandDetailPage);
		}
    }
}

