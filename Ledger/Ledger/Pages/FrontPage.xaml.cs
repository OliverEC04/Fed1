using Ledger.ViewModels;

namespace Ledger.Pages;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
		BindingContext = new FrontPageViewModel();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await (BindingContext as FrontPageViewModel)?.LoadDebtorsAsync();
	}
}
