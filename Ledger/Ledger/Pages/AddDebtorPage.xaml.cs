using Ledger.ViewModels;
namespace Ledger.Pages;


public partial class AddDebtorPage : ContentPage
{
	public AddDebtorPage()
	{
		InitializeComponent();
		BindingContext = new AddDebtorViewModel();
	}
}