using Mathematical_Qizz.model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Qizz.services
{
    internal class loginservice : Iloginrepository
    {
        private SQLiteAsyncConnection _dbConnection;

        public loginservice()
        {
            if (_dbConnection == null)
            {
                setupdb();
            }

        }
        private async void setupdb()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "login.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<login>();
        }
        public Task<int> AdduserAsync(login lg)
        {
            return _dbConnection.InsertAsync(lg);
        }

        public async Task<List<login>> LoginAsync()
        {
            var userinfolist = await _dbConnection.Table<login>().ToListAsync();
            return userinfolist;
        }

        public Task<int> UpdateUserAsync(login lg)
        {
                return _dbConnection.UpdateAsync(lg);
            }
    }
}
