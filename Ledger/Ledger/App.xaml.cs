using Ledger.Pages;

namespace Ledger
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//  MainPage = new AppShell();
			MainPage = new Pages.AddDebtorPage(); // delete
		}
	}
}
