using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "one");
            list.Add(5, "fife");
            list.Add(10, "ten");
            list.Add(4, "four");
            list.Add(3, "tree");
            list.ShowSortedUp();
            Console.WriteLine(new string('-', 20));
            list.ShowSortedDown();
            Console.ReadKey();

        }
    }

    public class SortedList<T, U>
    {
        Dictionary<T, U> List = new Dictionary<T, U>();


        public void Add(T key, U value)
        {
            List.Add(key, value);
        }

        public void ShowSortedUp()
        {
            Console.WriteLine("SortedUp list by key:");
            var sortedDictByOrder = List.OrderBy(x => x.Key);
            foreach (KeyValuePair<T, U> item in sortedDictByOrder)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }

        public void ShowSortedDown()
        {
            Console.WriteLine("SortedDown list by key:");
            var sortedDictByOrder = List.OrderByDescending(x => x.Key);
            foreach (KeyValuePair<T, U> item in sortedDictByOrder)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
