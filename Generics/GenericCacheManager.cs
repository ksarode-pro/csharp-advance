using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Generics
{
    /// <summary>
    /// A class to maintaine generic data caching
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCacheManager<T>
    {
        Dictionary<string, T> _internalDict;

        public GenericCacheManager()
        {
            _internalDict = new Dictionary<string, T>();
        }

        /// <summary>
        /// Adds keya and data into cache
        /// </summary>
        /// <param name="key">cache key</param>
        /// <param name="data">cached object</param>
        public void Add(string key, T data)
        {
            if(!_internalDict.ContainsKey(key))
            {
                _internalDict.Add(key, data);
                System.Console.WriteLine($"{key} key is added");
            }
            else
                System.Console.WriteLine($"{key} key is already present in cache");
        }

        /// <summary>
        /// Pulls data assiciated with key from cache
        /// </summary>
        /// <param name="key">cache key</param>
        /// <returns>cached object</returns>
        public T? Get(string key)
        {
            if(_internalDict.Count > 0 && _internalDict.ContainsKey(key))
                return _internalDict[key];
            else    
                return default(T);
        }

        /// <summary>
        /// Deleted item from cache
        /// </summary>
        /// <param name="key">cache key</param>
        public void Delete(string key)
        {
            if(_internalDict.Count > 0 && _internalDict.ContainsKey(key))
            {
                _internalDict.Remove(key);
                System.Console.WriteLine($"{key} key is deleted");
            }
            else
            { 
                System.Console.WriteLine($"{key} key does not exist");
            }
        }
        /// <summary>
        /// clears all keys and related cache objects
        /// </summary>
        public void DeleteAll()
        {
            _internalDict.Clear();
            System.Console.WriteLine($"Cache is completely cleared");
        }
        
    }
}