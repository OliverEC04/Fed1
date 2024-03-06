using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Ledger.ViewModels
{
	public partial class AddDebtorViewModel : ObservableObject
	{
		private readonly INavigation _navigation;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private float initialValue;

		public AddDebtorViewModel(INavigation navigation)
		{
			_navigation = navigation;
		}

		[RelayCommand]
		public void Save()
		{
			// Code for saving data
		}

		[RelayCommand]
		public async void Cancel()
		{
			await _navigation.PopToRootAsync();
		}
	}
}
