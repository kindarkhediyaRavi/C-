using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiCast
{
    public delegate void d1();
    internal class Program
    {
        static void f1() { Console.WriteLine("First..."); }
        static void f2() { Console.WriteLine("Second..."); }
        static void f3() { Console.WriteLine("Third..."); }

        static void Main(string[] args)
        {
            d1 obj = new d1(f1);
            obj();

            Console.WriteLine("\n After Add f2 and f3");

            obj += new d1(f2);  // add f2 and f3 method  
            obj += new d1(f3);
            obj();
            Console.WriteLine("\n After f2 Remove");
            obj -= new d1(f2); // sub f2
            obj();
            Console.ReadLine();
        }
    }
}
