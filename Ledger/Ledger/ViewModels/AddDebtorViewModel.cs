using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Xml.Linq;
using Ledger.Database; // This imports the namespace where your Database class is
using Ledger.Models;

namespace Ledger.ViewModels
{
	public partial class AddDebtorViewModel : ObservableObject
	{
		private readonly INavigation _navigation;
		private readonly Ledger.Database.Database _database = new Ledger.Database.Database(); // Use the full namespace

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private float initialValue;

		public AddDebtorViewModel(INavigation navigation)
		{
			_navigation = navigation;
		}

		[RelayCommand]
		public async void Save()
		{
			var debtor = new Debtor
			{
				Name = Name,
				Debt = InitialValue
			};

			await _database.AddDebtor(debtor);
			await _navigation.PopAsync();
		}

		[RelayCommand]
		public async void Cancel()
		{
			await _navigation.PopToRootAsync();
		}
	}
}
