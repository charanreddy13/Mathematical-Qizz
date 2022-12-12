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

        public Task<int> AdduserAsync(Login lg)
        {
            return _dbConnection.InsertAsync(lg);
        }

        public async Task<List<Login>> LoginAsync()
        {
            var userinfolist = await _dbConnection.Table<Login>().ToListAsync();
            return userinfolist;
        }

        public Task<int> UpdateUserAsync(Login lg)
        {
                return _dbConnection.UpdateAsync(lg);
            }
    }
}
