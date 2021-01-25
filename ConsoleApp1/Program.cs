using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New changes");
            Console.WriteLine("abc");
            Task1();
        }

        static void Task1()
        {
            Console.WriteLine("zz2");
            Console.WriteLine("Task1");
            Console.WriteLine(58);
            Console.WriteLine(10);
            Console.WriteLine(8);
            Console.WriteLine(58);
            Console.WriteLine(10);
            Console.WriteLine(8);
            Console.WriteLine("ff");
        }
    }
}
