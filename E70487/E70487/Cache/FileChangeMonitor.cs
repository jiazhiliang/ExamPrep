using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Caching;


namespace E70487.Cache
{
    public class TestFileChangeMonitor : FileChangeMonitor
    {
        public override ReadOnlyCollection<string> FilePaths => throw new NotImplementedException();

        public override DateTimeOffset LastModified => throw new NotImplementedException();

        public override string UniqueId => throw new NotImplementedException();

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }



}