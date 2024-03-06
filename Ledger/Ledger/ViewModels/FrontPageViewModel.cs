﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ledger.Pages;


namespace Ledger.ViewModels
{
	public partial class FrontPageViewModel : ObservableObject
	{
		[ObservableProperty]
		private string _title = "Debtors";
		private List<Tuple<string, int>> _debtors;

		[RelayCommand]
		public async void AddDebtor()
		{
			await Application.Current.MainPage.Navigation.PushAsync(new AddDebtorPage());
		}


		public FrontPageViewModel()
		{

		}
	}
}