using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColllectionAndFileIoOperationsDemo
{
    public class CollectionsDemo
    {
        public static void GenericsCollections()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine("Element in Generics list");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void DictionaryCollections()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Somu");
            dict.Add(2, "Anil");
            dict.Add(3, "Manju");
            foreach (var data in dict)
            {
                Console.WriteLine("Key ->" + data.Key + "   " + "Value->" + data.Value);
            }
            Console.WriteLine(dict.ContainsKey(3));
        }
        public static void SortedDictionaryCollections()
        {
            SortedList<int, string> sort = new SortedList<int, string>();
            sort.Add(7, "Rama");
            sort.Add(5, "Raja");
            sort.Add(1, "Somu");
            sort.Add(2, "Anil");
            sort.Add(3, "Manju");
            foreach (var data in sort)
            {
                Console.WriteLine("Key ->" + data.Key + "   " + "Value->" + data.Value);
            }
            //Console.WriteLine(sort.ContainsKey(3));
        }
        public static void GenericStackCollections()
        {
            Stack<string> sta = new Stack<string>();
            sta.Push("Somu");
            sta.Push("Anil");
            sta.Push("Shekar");
            sta.Push("Kumar");
            foreach (string data in sta)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("==============");
            string result = sta.Pop();
            Console.WriteLine(result);
            Console.WriteLine("---------------");
            string op = sta.Peek();
            Console.WriteLine(op);
        }
        public static void GenericQueueCollections()
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Somu");
            que.Enqueue("Anil");
            que.Enqueue("Shekar");
            que.Enqueue("Kumar");
            foreach (string data in que)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("==============");
            string result = que.Dequeue();
            Console.WriteLine(result);
            Console.WriteLine("---------------");
            string op = que.Dequeue();
            Console.WriteLine(op);
            var clear = que.Dequeue();
        }
        public static void GenericsLinkedListCollection()
        {
            LinkedList<int> link = new LinkedList<int>();
            link.AddFirst(10);
            link.AddFirst(20);
            link.AddFirst(30);
            link.AddFirst(40);
            foreach (int data in link)
            {
                Console.WriteLine(data);
            }
        }
    }
}
