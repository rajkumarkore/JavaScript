using System;
using System.IO;
namespace FileIO
{
    class FileReader
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("D:\\om.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.Read();

            }
        }
    }
}
