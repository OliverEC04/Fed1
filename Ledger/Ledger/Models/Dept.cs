using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.Models
{
	public class Dept
	{
		public int Id { get; set; } // Assuming you'll add a database later.
		public double Amount { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; } = string.Empty;

		// If you plan to link this to a Debtor model later on
		// public int DebtorId { get; set; }
	}
}
