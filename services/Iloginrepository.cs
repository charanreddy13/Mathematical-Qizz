using Mathematical_Qizz.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Qizz.services
{
    public interface Iloginrepository
    {
        Task<List<Login>> LoginAsync();

        Task<int> AdduserAsync(Login lg);

        Task<int> UpdateUserAsync(Login lg);
    }
}
