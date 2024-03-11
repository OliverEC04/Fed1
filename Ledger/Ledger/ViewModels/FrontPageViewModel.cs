using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ledger.Models;
using Ledger.Pages;


namespace Ledger.ViewModels
{
	public partial class FrontPageViewModel : ObservableObject
	{
		[ObservableProperty]
		private string _title = "Debtors";
		[ObservableProperty]
		private ObservableCollection<Debtor> _debtors;
		[ObservableProperty]
		private Debtor _selectedDebtor;

		[RelayCommand]
		public async Task SelDebtor()
		{
			if (_selectedDebtor != null)
			{
				await Application.Current.MainPage.Navigation.PushAsync(new AddDebtorPage());
			}
		}


		[RelayCommand]
		public async void AddDebtor()
		{
			await Application.Current.MainPage.Navigation.PushAsync(new AddDebtorPage()); // oh ja der kom jeg
		}

		[RelayCommand]
		public async void GoList()
		{
			await Application.Current.MainPage.Navigation.PushAsync(new DebtorListPage());
		}

		public FrontPageViewModel()
		{

		}
	}
}
