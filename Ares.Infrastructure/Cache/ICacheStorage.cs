using System;
using System.Collections.Generic;


namespace Ares.Infrastructure.Cache
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string storageKey);
    }
}
