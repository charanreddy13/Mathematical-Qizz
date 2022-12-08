using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Qizz.model
{
    public class login
    {
        [AutoIncrement]
        public int Id { get; set; }

        [PrimaryKey]
        public string username { get; set; }

        public string password { get; set; }

        public int score { get; set; }
    }
}
