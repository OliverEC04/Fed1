using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace Ledger.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] private List<Tuple<string, int>> _debtors;

        [RelayCommand]
        private void AddDebtor()
        {

        }

        public MainPageViewModel()
        {
            
        }
    }
}
