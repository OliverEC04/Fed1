using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.ViewModels
{
    public partial class DebtorListViewModel : ObservableObject
    {
        [ObservableProperty] private List<Tuple<string, int>> ?_debtorDetails;

        //public DebtorListPageViewModel()
        //{
        //    Title = "Hello, MVVM Toolkit!";
        //}
    }
}
