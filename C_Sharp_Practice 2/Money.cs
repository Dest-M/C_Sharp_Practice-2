
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace C_Sharp_Practice_2
{
    internal class Money
    {
        
        int dollars = 0;
        int cents = 0;
        public void entercash()
        {
            Console.WriteLine("Enter dollars: ");
            dollars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cents: ");
            cents = Convert.ToInt32(Console.ReadLine());
        }
        public void entercash(int a, int b)
        {
            if (cents >= b)
            {
                cents = cents - b;
            }
            else
            {
               if(b > 100)
                {
                    while(b > 100)
                    {
                        cents = b - 100;
                        dollars--;
                    }
                }
               if(b > cents)
                {
                    cents = 100 - (b - cents);
                    dollars--;
                }
            }
            if (a <= dollars)
            {
                dollars = dollars- a;
            }
            else
            {
                dollars = 0;
            }
        }
        public void display()
        {
            Console.WriteLine("Cost is " + Convert.ToString(dollars)+" dollars and " + Convert.ToString(cents)+ " cents\n");
        }
    }
    internal class Product
    {
        
        Money price = new Money();
        string name;
        public Product()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            price.entercash();
        }
        public void discount(int a, int b)
        {
            price.entercash(a, b);
        }
        public void display()
        {
            Console.WriteLine("\t" + name + "\n_________________________");
            price.display();
        }
    }
}