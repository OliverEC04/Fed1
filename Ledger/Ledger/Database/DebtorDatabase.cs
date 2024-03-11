using Ledger.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.Database
{
	internal class Database
	{
		private readonly SQLiteAsyncConnection _connection;

		public Database()
		{
			var dataDir = FileSystem.AppDataDirectory;
			var databasePath = Path.Combine(dataDir, "Ledger.db");
			var dbOptions = new SQLiteConnectionString(databasePath, storeDateTimeAsTicks: false);

			_connection = new SQLiteAsyncConnection(dbOptions);

			_ = Initialise();
		}

		private async Task Initialise()
		{
			await _connection.CreateTableAsync<Debtor>();
			await _connection.CreateTableAsync<Dept>();
		}

		public async Task<List<Debtor>> GetDebtors()
		{
			return await _connection.Table<Debtor>().ToListAsync();
		}

		public async Task<Debtor> GetDebtor(int id)
		{
			var query = _connection.Table<Debtor>().Where(d => d.DebtorId == id);
			return await query.FirstOrDefaultAsync();
		}

		public async Task<int> AddDebtor(Debtor item)
		{
			return await _connection.InsertAsync(item);
		}

		public async Task<int> DeleteDebtor(Debtor item)
		{
			return await _connection.DeleteAsync(item);
		}

		public async Task<int> UpdateDebtor(Debtor item)
		{
			return await _connection.UpdateAsync(item);
		}

		public async Task<List<Dept>> GetDebts()
		{
			return await _connection.Table<Dept>().ToListAsync();
		}

		public async Task<Dept> GetDebt(int id)
		{
			var query = _connection.Table<Dept>().Where(d => d.Id == id);
			return await query.FirstOrDefaultAsync();
		}

		public async Task<List<Dept>> GetDebtsFromDebtor(int debtorId)
		{
			var query = _connection.Table<Dept>().Where(d => d.DebtorId == debtorId);
			return await query.ToListAsync();
		}

		public async Task<int> AddDebt(Dept item)
		{
			return await _connection.InsertAsync(item);
		}

		public async Task<int> DeleteDebt(Dept item)
		{
			return await _connection.DeleteAsync(item);
		}

		public async Task<int> UpdateDebt(Dept item)
		{
			return await _connection.UpdateAsync(item);
		}
	}
}
