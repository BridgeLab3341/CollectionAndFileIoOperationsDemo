using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColllectionAndFileIoOperationsDemo
{
    public class FileIoOperationDDemo
    {
        public static void File_Exits_or_Not()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exits");
            }
             else
            {
                Console.WriteLine("Not Exits");
            }
        }
        public static void ReadAll_Lines()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(" ");
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
        }
        public static void Read_All_Texts()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            string textes;
            textes = File.ReadAllText(path);
            Console.WriteLine(textes);
        }
        public static void Copy_File()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            string path1 = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\CopiedTextFile.txt";
            File.Copy(path, path1);
        }
        public static void Delete_File()
        {
            string path1 = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\CopiedTextFile.txt";
            File.Delete(path1);
        }
        public static void Write_Lines()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\WriteData.txt";
            string[] data = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            File.WriteAllLines(path, data);
        }
        public static void Append_Data()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            string data = "Temp";
            File.AppendAllText(path, data);
            Console.WriteLine(data);
        }
        public static void Stream_Reader()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\DemoText.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string data = " ";
                string da = sr.ReadLine();
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
        public static void Stream_Writer()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\WriteData.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Somasheakr");
                writer.WriteLine("Anilkumar");
            }
        }
        public static void Create_File_Using_FileStream()
        {
            string path = @"D:\ReMapBridgeLabs\CollectionAndFileIoOperationsDemo\ColllectionAndFileIoOperationsDemo\Data.txt";
            FileStream file = new FileStream(path, FileMode.Create);
        }
    }
}
