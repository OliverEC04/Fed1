using Ledger.ViewModels;

namespace Ledger.Pages;

public partial class DebtorListPage : ContentPage
{
	public DebtorListPage()
	{
		InitializeComponent();
		BindingContext = new DebtorListViewModel(Navigation);
	}
}