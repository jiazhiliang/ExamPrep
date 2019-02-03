using System;
using System.Runtime.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using E70487.Cache;

namespace E70487Test
{
    [TestClass]
    public class Caching
    {
        [TestMethod]
        public void Item_Create_Approaches()
        {
            var cache = MemoryCache.Default;

            // 1: Insert as CacheItem
            cache.Add(new CacheItem
            (
                key: "item1",
                value: "value1",    // optional
                regionName: "section1"

            ), new CacheItemPolicy
            {
                // Can't specify with SlidingExpiration together
                // AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10), 

                Priority = CacheItemPriority.Default,
                RemovedCallback = e =>
                {
                },

                // Can't specify AbsoluteExpiration and SlidingExpiration together
                // UpdateCallback = e => 
                // {
                // },

                SlidingExpiration = TimeSpan.FromMinutes(10)

            });

            // 2: Insert as key value
            cache.Add("item2", "value2", new CacheItemPolicy
            {
            });

            // 3: Insert as key value and AbsoluteExpiration
            var result = cache.Add("item3", "value3", DateTimeOffset.Now.AddMinutes(10));
            if (result)
            {
                Console.WriteLine("Item is added");
            }
            else
            {
                Console.WriteLine("Item is NOT added. It's already there.");
            }

        }

        [TestMethod]
        public void Test_FileChangeMonitor()
        {
            var policy = new CacheItemPolicy
            {
            };

            policy.ChangeMonitors.Add(new TestFileChangeMonitor
            {
            });

            MemoryCache.Default.Set("item1", "value1", policy);

        }

    }
}
