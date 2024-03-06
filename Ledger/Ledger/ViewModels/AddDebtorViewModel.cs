using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Ledger.ViewModels
{
	public partial class AddDebtorViewModel : ObservableObject
	{
		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private float initialValue;

		[RelayCommand]
		public void Save()
		{
			// mangler dating base
		}

		[RelayCommand]
		public void Cancel()
		{
			// gå tilbag
		}
	}
}
