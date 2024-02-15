using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListUsing
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add(1);   // Add any Value 
            a.Add(true);
            a.Add("Jay Mataji");
            a.Insert(0, "All the Best ");
            foreach (object item in a)
            {
                Console.WriteLine(item);
            }

            Stack s = new Stack();
            s.Push(12);
            s.Push(13);
            s.Push(457);
            Console.WriteLine("\nAftre Stack using \n");
            foreach (object item in a)
            {
                Console.WriteLine(item);
            }

            a.InsertRange(2,s);   // Insert specific to Stack 
            foreach (object item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Counting : "+a.Count);  // Count Value

            Console.WriteLine("\n Capacity : "+a.Capacity);  // Check the Capacity
            Console.WriteLine( "First element is : "+a[0]);   // specific index of Value 

            a.Remove("All the Best");   // Remove Specific Value 
            Console.WriteLine("\nAfter Remove() ");
            foreach (object item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter RemoveAt() ");
            a.RemoveAt(2);   // Remove specific index of Value 
            foreach (object item in a)
            {
                Console.WriteLine(item);
            }

            a.RemoveRange(1,3); // remove 1 morethan element
            a.Clear();
            Console.ReadLine();
        }
    }
}
