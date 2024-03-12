using Ledger.ViewModels;

namespace Ledger.Pages;

public partial class DebtorListPage : ContentPage
{
	public DebtorListPage(int debtorId)
	{
		InitializeComponent();
		BindingContext = new DebtorListViewModel(Navigation, new Ledger.Database.Database(), debtorId);
	}
}
