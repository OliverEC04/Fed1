using SQLite;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ledger.Models
{
	public class Dept
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public double Amount { get; set; }

		[ForeignKey(nameof(Debtor))]
		public int DebtorId { get; set; }  // Changed from DeptorID to DebtorId
		public string Description { get; set; } = string.Empty;
		public DateTime Date { get; set; }
	}
}
