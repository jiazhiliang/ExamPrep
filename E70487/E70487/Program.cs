using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections.ObjectModel;
using System.Transactions;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace E70487
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new EntityConnection();
            var trans = conn.CurrentTransaction;
        }
    }
}
