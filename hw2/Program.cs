using System;
using System.Collections.Generic;

namespace hw1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            for (int i = 0; i < 20; i++)
            {
                list.Add("e" + i);
            }
            Console.WriteLine(list.GetType());
            for (int i = 0; i < 20; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine(new string('-', 25));

            //Console.WriteLine(list.Contains("e5"));
            //list.Clear();
            //list.Show();
            string[] test = Addition.GetArray<string>(list);
            Console.WriteLine(test.GetType());
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.ReadKey();


        }

    }

    static class Addition
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }

    public interface IMyList<T>
    {
        void Add(T a) { }
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);

    }

    public class MyList<T> : IMyList<T>
    {
        private T[] arr = new T[] { };

        public MyList()
        {
            T[] arr = { };
        }
        public T GetValueByIndex { get; set; }

        public void Add(T a)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = a;
        }

        public T this[int index]
        {
            get { return arr[index]; }
            set { GetValueByIndex = value; }
        }

        public int Count
        {
            get { return arr.Length; }
        }

        public void Clear()
        {
            Array.Resize(ref arr, 0);
        }

        public bool Contains(T item)
        {
            foreach (T current in arr)
            {
                if ((object)current == (object)item)
                {
                    return true;
                }
            }
            return false;
        }
        public void Show()
        {
            foreach (T item in arr)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
