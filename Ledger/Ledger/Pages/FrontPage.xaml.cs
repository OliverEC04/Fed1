using Ledger.ViewModels;

namespace Ledger.Pages;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
        BindingContext = new FrontPageViewModel();
    }
}