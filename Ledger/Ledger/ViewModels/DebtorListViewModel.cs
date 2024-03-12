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
		private readonly Database.Database _database;
		private int _debtorId;

		[ObservableProperty]
		private ObservableCollection<Dept> _debtorDetails;

		public DebtorListViewModel(INavigation navigation, Database.Database database, int debtorId)
		{
			_navigation = navigation;
			_database = database;
			_debtorId = debtorId;
			DebtorDetails = new ObservableCollection<Dept>();
			LoadDebtorDetails();
		}

		private async void LoadDebtorDetails()
		{
			var transactions = await _database.GetDebtsFromDebtor(_debtorId);
			DebtorDetails.Clear();
			foreach (var transaction in transactions)
			{
				DebtorDetails.Add(transaction);
			}
		}

		[RelayCommand]
		public async void Cancel()
		{
			await _navigation.PopToRootAsync();
		}

		[RelayCommand]
		public async void AddTransaction()
		{
			// enter amount
			string amountInput = await Application.Current.MainPage.DisplayPromptAsync("New Transaction", "Enter the amount:", "OK", "Cancel", null, -1, keyboard: Keyboard.Numeric);
			if (double.TryParse(amountInput, out double amount))
			{
				// enter date
				string dateInput = await Application.Current.MainPage.DisplayPromptAsync("Transaction Date", "Enter the date (MM/dd/yyyy):", "OK", "Cancel", initialValue: DateTime.Now.ToString("MM/dd/yyyy"), maxLength: 10, keyboard: Keyboard.Text);

				if (DateTime.TryParseExact(dateInput, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime transactionDate))
				{
					// new debt object
					Dept newTransaction = new Dept
					{
						DebtorId = _debtorId,
						Amount = amount,
						Date = transactionDate
					};

					// add to database
					await _database.AddDebt(newTransaction);

					// reload list
					LoadDebtorDetails();
				}
				else
				{
					await Application.Current.MainPage.DisplayAlert("Error", "Wrong date. use mm/dd/yyyy.", "OK");
				}
			}
			else
			{
				await Application.Current.MainPage.DisplayAlert("Error", "Invalid amount. Please enter a int number.", "OK");
			}
		}
	}

}

