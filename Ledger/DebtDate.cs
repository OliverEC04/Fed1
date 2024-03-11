using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.UI.Models
{
    public class DebtDate
    {
        [PrimaryKey, AutoIncrement]
        public int DebtId { get; set; }

        [ForeignKey(nameof(Debtor))]
        public int DebtorId { get; set; }
        public DateTime Date { get; set; }
    }
}