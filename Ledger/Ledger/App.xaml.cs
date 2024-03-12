using Ledger.Pages;

namespace Ledger
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			if (Microsoft.Maui.Controls.Application.Current != null)
				Microsoft.Maui.Controls.Application.Current.UserAppTheme = AppTheme.Dark;
			MainPage = new NavigationPage(new FrontPage());
		}
	}
}
