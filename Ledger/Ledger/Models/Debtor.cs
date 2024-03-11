using SQLite;

namespace Ledger.Models
{
	public class Debtor
	{
		[PrimaryKey, AutoIncrement]
		public int DebtorId { get; set; }
		public string Name { get; set; }
		public double Debt { get; set; }
	}
}
