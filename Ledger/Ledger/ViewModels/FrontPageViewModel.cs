using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Ledger.ViewModels
{
    public partial class FrontPageViewModel : ObservableObject
    {
        [ObservableProperty] 
        private string _title = "Debtors";
        private List<Tuple<string, int>> _debtors;

        [RelayCommand]
        public void AddDebtor()
        {
            
        }

        public FrontPageViewModel()
        {
            
        }
    }
}
