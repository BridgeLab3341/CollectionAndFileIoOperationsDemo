using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColllectionAndFileIoOperationsDemo
{
    public class NonGenericCollections
    {
        public static void ArrayListNonGenericCollections()
        {
            ArrayList list = new ArrayList();
            string input = "My Name is Somu";
            int i = 10;
            DateTime dt = DateTime.Now;
            DateTime dateTime = DateTime.Parse("23-jan-2023");
            list.Add(input);
            list.Add(dt);
            list.Add(dateTime);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void HashTableNonGenrics()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "Soda");
            hash.Add(2, "Limca");
            hash.Add(3, "Sprite");
            hash.Add(4, "Sting");
            foreach (DictionaryEntry entry in hash)
            {
                Console.WriteLine(entry.Key + "   " + entry.Value);
            }
        }
        public static void SortListNonGenrics()
        {
            SortedList sort = new SortedList();
            sort.Add(1, "Soda");
            sort.Add(2, "Limca");
            sort.Add(3, "Sprite");
            sort.Add(4, "Sting");
            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine(entry.Key + "   " + entry.Value);
            }
        }
    }
}
