using mauiProject.Models;
using mauiProject.Services;

namespace mauiProject.Views;

[QueryProperty(nameof(id), "id")]
public partial class BrandDetail : ContentPage
{
	public BrandModel brand;
	private readonly IBrandService _brandService;
	public Guid id;
	public BrandDetail(IBrandService brandService)
	{
		InitializeComponent();

		_brandService = brandService;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		getBrandById();
	}

	private async void getBrandById() 
	{
		brand = await _brandService.GetById(id);
		await DisplayAlert("Probando getBrandById", brand != null ?
		 "El elemento es: " + brand.name : "No se encontró el elemento", "OK");
	}
}