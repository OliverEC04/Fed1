using DebtBook.UI.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.UI.Data
{
    internal class Database
    {
        private readonly SQLiteAsyncConnection _connection;

        public Database()
        {
            var dataDir = FileSystem.AppDataDirectory;
            var databasePath = Path.Combine(dataDir, "Debtors.db");
            var dbOptions = new SQLiteConnectionString(databasePath, true);

            _connection = new SQLiteAsyncConnection(dbOptions);

            _ = Initialise();
        }

        private async Task Initialise()
        {
            await _connection.CreateTableAsync<Debtor>();
            await _connection.CreateTableAsync<Debt>();
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

        public async Task<List<Debt>> GetDebts()
        {
            return await _connection.Table<Debt>().ToListAsync();
        }

        public async Task<Debt> GetDebt(int id)
        {
            var query = _connection.Table<Debt>().Where(d => d.DebtId == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Debt>> GetDebtsFromDebtor(int debtorId)
        {
            var query = _connection.Table<Debt>().Where(d => d.DebtorId == debtorId);

            return await query.ToListAsync();
        }

        public async Task<int> AddDebt(Debt item)
        {
            return await _connection.InsertAsync(item);
        }

        public async Task<int> DeleteDebt(Debt item)
        {
            return await _connection.DeleteAsync(item);
        }

        public async Task<int> UpdateDebt(Debt item)
        {
            return await _connection.UpdateAsync(item);
        }

        public async Task<int> GetDebtDate(int debtorId)
        {
            var query = _connection.Table<Debt>().Where(debtorId => debtorId.DebtorId == debtorId);

            return await query.ToListAsync();
        }
    }

}
