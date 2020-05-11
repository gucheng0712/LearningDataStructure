using System;


/// <summary>
/// Design and implement a data structure for Least Recently Used(LRU) cache.It should support the following operations: get and put.
/// 
/// get(key) - Get the value(will always be positive) of the key if the key exists in the cache, otherwise return -1.
/// put(key, value) - Set or insert the value if the key is not already present.When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.
/// 
/// The cache is initialized with a positive capacity.
/// 
/// </summary>


namespace LRU_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache cache = new LRUCache(2 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);

            Console.WriteLine(cache.Get(1)); // returns 1
            cache.Put(3, 3); // evicts key 2
            Console.WriteLine(cache.Get(2)); // returns -1 (not found)
            cache.Put(4, 4); // evicts key 1
            Console.WriteLine(cache.Get(1)); // returns -1 (not found)
            Console.WriteLine(cache.Get(3)); // returns 3
            Console.WriteLine(cache.Get(4)); // returns 4
        }
    }
}
