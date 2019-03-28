using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeanClassDirectoryandFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"c:\windows\", "*.log"); //, SearchOption.AllDirectories);
            foreach (string  _string in files)
            {
                Console.WriteLine("File name: {0}", _string);
            }

            Console.ReadKey();
        }
    }
}
