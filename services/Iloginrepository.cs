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
        Task<List<login>> LoginAsync();

        Task<int> AdduserAsync(login lg);

        Task<int> UpdateUserAsync(login lg);
    }
}
