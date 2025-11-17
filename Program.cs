using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOstream1
{
    public class Program2
    {
        public static void Main()
        {
            System.IO.StreamWriter sw = System.IO.File.CreateText("test2.txt");

            sw.Write("Innovative");
            sw.Write(4500);
            sw.Write(4500.555);

            sw.WriteLine("hello");
            sw.WriteLine("how are you");
            sw.Close();

            System.IO.StreamReader sr = System.IO.File.OpenText("test2.txt");
            System.Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

    }
}
