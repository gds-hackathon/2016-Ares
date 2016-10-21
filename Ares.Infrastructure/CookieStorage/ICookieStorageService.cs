using System;

namespace Ares.Infrastructure.CookieStorage
{
    public interface ICookieStorageService
    {
        void Save(string key, string value, DateTime expires);

        string Retrieve(string key);
    }
}
