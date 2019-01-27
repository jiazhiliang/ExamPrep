using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections.ObjectModel;

namespace E70487
{

    public class MyMonitor : CacheEntryChangeMonitor
    {
        public override ReadOnlyCollection<string> CacheKeys => throw new NotImplementedException();

        public override DateTimeOffset LastModified => throw new NotImplementedException();

        public override string RegionName => throw new NotImplementedException();

        public override string UniqueId => throw new NotImplementedException();

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cache = MemoryCache.Default;



        }
    }
}
