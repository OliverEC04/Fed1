using Ledger.ViewModels;

namespace Ledger.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private void OnAddDebtor(object? sender, EventArgs e)
    {
        Console.WriteLine("kanppen er gay");
    }
}