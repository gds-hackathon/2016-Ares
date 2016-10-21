using System;
using System.Collections.Generic;
using System.Web.Caching;
using System.Web;

namespace Ares.Infrastructure.Cache
{
    public class CacheHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetRequestCache<T>(string key)
        {
            return (T)HttpContext.Current.Items[key];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetRequestCache<T>(string key, T value)
        {
            HttpContext.Current.Items[key] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetApplicationCache<T>(string key)
        {
            return (T)HttpContext.Current.Cache[key];
        }


        private int CacheTime
        {
            get;
            set;
        }


        public static T GetUser<T>(string key)
        {
            return (T)HttpContext.Current.Cache[key];
        }

        /// <summary>
        /// Save item to cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <param name="value"></param>
        public static void SaveToCache<T>(string cacheKey, T value)
        {
            System.Web.Caching.Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, value);
        }

        /// <summary>
        ///  Save item to  cache with absolute time
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <param name="value"></param>
        /// <param name="expirationDate"></param>
        public static void SaveToCache<T>(string cacheKey, T value, DateTime expirationDate)
        {
            System.Web.Caching.Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, value, null, expirationDate, System.Web.Caching.Cache.NoSlidingExpiration);
        }

        public static T GetFromCache<T>(string cacheKey)
        {
            return (T)HttpRuntime.Cache[cacheKey];
        }
    }
}
