using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.UI.Models
{
    public class Debt
    {
        [PrimaryKey, AutoIncrement]
        public int DebtId { get; set; }
        public double Amount { get; set; }

        [ForeignKey(nameof(Debtor))]
        public int DebtorId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}