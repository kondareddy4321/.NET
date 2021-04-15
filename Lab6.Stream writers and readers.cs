using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "Z:\\C#.NET lab\\lab06\\lab06\\bin\\Debug\\lab06.txt";
            Console.WriteLine("WRITING TO A FILE");
            WriteToFile(filepath);
            Console.WriteLine("READING FROM A FILE");
            ReadFromFile(filepath);
        }
        public static void ReadFromFile(string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            int count = 0;
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            reader.Close();
        }
        public static void WriteToFile(string filepath)
        {
            StreamWriter writer = new StreamWriter(filepath, true);
            string temp = string.Empty;
            Console.WriteLine("enter name[-1 to exit]:");
            do
            {

                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    writer.WriteLine(temp);
                }
            } while (temp != "-1");
            writer.Close();
            Console.ReadLine();
        }
    }
}
