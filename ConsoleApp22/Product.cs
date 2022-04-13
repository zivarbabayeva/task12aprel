using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalIncome { get; set; }
        public int Sell { get; set; }


        public int Sell(string str)
        {
            Console.WriteLine("Satish bash verdi");
            Count--;
            if (Count == 0)
            {
                Console.WriteLine("Satis bas vere bilmez");
            }
            TotalIncome++;
           Console.WriteLine("Name Daxil Et:");
            string Name = Console.ReadLine();
            if (Name == null)
            {
                Console.WriteLine("Product obyekti yaradila bilmez");
            }
        }

        public Product (string name, double price, int count, double totalIncome)
        {
            Name = name;
            Price = price;
            Count = count;
            TotalIncome = totalIncome;
        }
    }
}