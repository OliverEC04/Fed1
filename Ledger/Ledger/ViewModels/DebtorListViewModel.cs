using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ledger.Models;
using System.Collections.ObjectModel;
using System;

namespace Ledger.ViewModels
{
	public partial class DebtorListViewModel : ObservableObject
	{
		private readonly INavigation _navigation;

		[ObservableProperty]
		private ObservableCollection<Dept> _debtorDetails;

		public DebtorListViewModel(INavigation navigation)
		{
			_navigation = navigation;
			DebtorDetails = new ObservableCollection<Dept>();
		}

		[RelayCommand]
		public async void Cancel()
		{
			await _navigation.PopToRootAsync();
		}

		[RelayCommand]
		public void AddTransaction()
		{
			var random = new Random();
			var amount = random.Next(-1000, 1000);
			var date = DateTime.Now;
			DebtorDetails.Add(new Dept { Date = date, Amount = amount, Description = "maan idk" });
		}
	}
}
