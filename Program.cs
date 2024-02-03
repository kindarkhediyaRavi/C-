using System;

namespace InterfaceExample
{
    public interface IProduct
    {
        int Pid { get; set; }
        string Pname { get; set; }
        double Price { get; set; }
        double Pro_qty(int qty);
    }

    public class Myclass : IProduct
    {
        int id;
        string name;
        double cost;

        public int Pid
        {
            get { return id; }
            set { id = value; }
        }
        public string Pname
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return cost; }
            set { cost = value; }
        }

        public double Pro_qty(int qty)
        {
            return Price * qty;
        }

        public void Disp()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Cost is " + cost);

        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Pid = 1;
            obj.Pname = "Ram";
            obj.Price = 12.25;
            obj.Disp();
            Console.WriteLine("total cost is " + obj.Pro_qty(5));
            Console.ReadLine();
        }
    }
}