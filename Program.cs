using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoArgumen_No_return_in_delegate
{
    public delegate void outClassDelegate(String n);
    class myclass
    {
        public static void welcome(string m)
        {
            Console.WriteLine("Welcome " + m);
        }
    }
    public delegate void d1();
    internal class Program
    {
        static void HI() 
        {
            Console.WriteLine(" Hi how are you? ");
        }
        static void get()
        {
            Console.WriteLine("Welcom to C#");
        }
        static void Main(string[] args)
        {
            d1 o1 = new d1(HI);
            o1();  // call HI method 
            o1 = get;  // get method refferance Assign in o1 
            o1();  // call get method 

            // out side class on delegate create 

            outClassDelegate d2 = new outClassDelegate(myclass.welcome);  // get the class name because method is static 
            d2("Ravi");
            Console.ReadLine();
        }

    }
}
