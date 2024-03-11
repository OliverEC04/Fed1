using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ledger.Models;
using Ledger.Database;
using Ledger.Pages;
using System.Threading.Tasks;

namespace Ledger.ViewModels
{
	public partial class FrontPageViewModel : ObservableObject
	{
		private readonly Database.Database _database = new Database.Database();

		[ObservableProperty]
		private string _title = "Debtors";

		[ObservableProperty]
		private ObservableCollection<Debtor> _debtors;

		[ObservableProperty]
		private Debtor _selectedDebtor;

		public FrontPageViewModel()
		{
			Debtors = new ObservableCollection<Debtor>();
			LoadDebtorsAsync();
		}

		[RelayCommand]
		public async Task SelDebtor()
		{
			if (_selectedDebtor != null)
			{
                await Application.Current.MainPage.Navigation.PushAsync(new DebtorListPage());
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

		public async Task LoadDebtorsAsync()
		{
			var debtorsList = await _database.GetDebtors();
			Debtors.Clear();
			foreach (var debtor in debtorsList)
			{
				Debtors.Add(debtor);
			}
		public FrontPageViewModel()
        {
            _debtors = new();
		}
	}
}
