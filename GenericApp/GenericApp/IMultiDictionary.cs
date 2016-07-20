using System.Collections.Generic;

namespace GenericApp
{
    public interface IMultiDictionary<K,V>
    {
        void CreateNewValue(K key);
        void Add(K key, V value);
        bool Remove(K key);
        bool Remove(K key, V value);
        void Clear();
        bool ContainsKey(K key);
        bool Contains(K key, V value);
        ICollection<K> Keys { get; }
        ICollection<V> Values { get; }
        int Count { get; }
    }
}