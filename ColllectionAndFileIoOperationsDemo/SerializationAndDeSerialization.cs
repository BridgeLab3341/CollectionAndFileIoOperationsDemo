using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ColllectionAndFileIoOperationsDemo
{
    [Serializable]
    public class Contacts
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public class SerializationAndDeSerialization
        {
            const string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\BinarySerializationData.txt";
            public static void Serialization()
            {
                List<Contacts> list = new List<Contacts>();
                {
                    new Contacts { Name = "Somu", Age = "23" };
                    new Contacts { Name = "Raju", Age = "28" };
                    new Contacts { Name = "Anil", Age = "24" };
                };
                FileStream stream = new FileStream(path, FileMode.Create);
                BinaryFormatter bn = new BinaryFormatter();
                bn.Serialize(stream, list);
                stream.Close();
                Console.WriteLine("convert object to Binary");
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            public static void xmlSerialization()
            {
                const string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\XmlDemo.xml";
                FileStream stream = new FileStream(path, FileMode.Create);
                XmlSerializer serialization = new XmlSerializer(typeof(List<Contacts>));
                List<Contacts> data = new List<Contacts>();
                {
                    new Contacts { Name = "Somu", Age = "24" };
                    new Contacts { Name = "Anil", Age = "26" };
                    new Contacts { Name = "Kumar", Age = "28" };
                    foreach (var d in data)
                    {
                        Console.WriteLine(d.Name + "  " + d.Age);
                    }
                };
                serialization.Serialize(stream, data);
            }
            public static void XmlDeserialization()
            {
                const string File_Path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\XmlDemo.xml";
                FileStream streamdata = new FileStream(File_Path, FileMode.Open);
                XmlSerializer serialization = new XmlSerializer(typeof(List<Contacts>));
                List<Contacts> data = (List<Contacts>)serialization.Deserialize(streamdata);
                streamdata.Close();
                foreach (var d in data)
                {
                    Console.WriteLine(d.Name);
                    Console.WriteLine(d.Age);
                }
            }
        }
    }
}
