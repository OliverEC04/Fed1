﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ledger.Pages;


namespace Ledger.ViewModels
{
	public partial class FrontPageViewModel : ObservableObject
	{
		[ObservableProperty]
		private string _title = "Debtors";
        [ObservableProperty]
        private ObservableCollection<Tuple<string, int>> _debtors;

		[RelayCommand]
		public async void AddDebtor()
		{
			await Application.Current.MainPage.Navigation.PushAsync(new AddDebtorPage()); // oh ja der kom jeg
		}


		public FrontPageViewModel()
		{

		}
	}
}
