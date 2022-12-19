using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegates_8
{
    public delegate void Func_del1(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Func_del1 del = new Func_del1(Con_output);
            del("Hello there!!!");
            Func_del1 de2 = new Func_del1(File_output);
            de2("Hello there!!!");

            Console.ReadKey();
        }
        public static void Con_output(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void File_output(string msg)
        {
            File.WriteAllText("output_file.txt", msg);
        }
    }
}
