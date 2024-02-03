using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(11.22);
            s.Push("Jay Shree Ram");
            s.Push("Jay Hanuman Dada");
            s.Push(true);

            foreach(object o in s)             // 11.22 / jay shree ram / 12 /
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\nAfter Pop() ");
            s.Pop();
            s.Pop();
            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            s.Push(12);
            s.Push(13);
            s.Pop();

            Console.WriteLine("\nPrint All Data ");
            foreach (object o in s)
            {
                Console.WriteLine(o);
            }
            // show the stack in current element
            Console.WriteLine("\nPeek() method used to Current value show : " + s.Peek());

            // Count Property used
            Console.WriteLine("\nCount Property used to Count value show : " + s.Count);

            // Clone Method used 
            Stack s2 = new Stack();
            s2 = (Stack)s.Clone();
            Console.WriteLine("\nAfter Clone() Method ");
            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Convert into Array ");
            object[] arr;
            arr = s.ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            s.Clear();
            Console.ReadLine();
        }
    }
}
