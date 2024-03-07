using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        //add the Back relay function
        [RelayCommand]
        public async void Back()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        //public DebtorListPageViewModel()
        //{
        //    Title = "Hello, MVVM Toolkit!";
        //}
    }
}
