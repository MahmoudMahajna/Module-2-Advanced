using System;
using System.Collections.Generic;

namespace GenericApp
{
    class Program
    {
        
        public struct A
        {
            int _a ;
           public A(int a)
            {
                _a = a;
            }
            public override string ToString()
            {
                return _a.ToString();
            }
        }
        static void Main(string[] args)
        {
            
            var multiDictionary = new MultiDictionary<Int, int>
            {
                {1, 1},
                {2, 2},
                {3, 3},
                {1, 11},
                {2, 22},
                {3, 33}
            };          
            DisplayMultiDictionary(multiDictionary);
            try
            {
                var multiDictionaryErr = new MultiDictionary<int, int>
            {
                {1, 1},
                {2, 2},
            };
            }catch(KeyAttributeDoesNotFountException e)
            {
                Console.WriteLine(e.Message);
            }
            DisplayMultiDictionary(multiDictionary);
            var mtd = new MultiDictionary<Int, A>();
            try
            {
                mtd.CreateNewValue(1);
                mtd.CreateNewValue(1);

                mtd.CreateNewValue(2);
                mtd.Add(1, new A(11));
                mtd.CreateNewValue(5);

                DisplayMultiDictionary(mtd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        public static void DisplayMultiDictionary<K,V>(MultiDictionary<K, V> multiDictionary) where V:struct where K:struct
        {
            foreach (var valueKey in multiDictionary)
            {
                DisplayValuesByKey(valueKey);
                Console.WriteLine();
            }
        }

        private static void DisplayValuesByKey<K,V>(KeyValuePair<K,ICollection<V>> keyValue)
        {
            Console.Write($"{keyValue.Key}: ");
            foreach (var value in keyValue.Value)
            {
                Console.Write($"{value}, ");
            }
        }
    }
}
