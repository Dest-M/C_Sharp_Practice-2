using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_2
{
    public class Worker
    {
        public string info;

        public void Print(President a) {
            Console.WriteLine("In charge of the country");
        }
        public void Print(Security a)
        {
            Console.WriteLine("Protects a place");
        }
        public void Print(Manager a)
        {
            Console.WriteLine("Manages a buiseness");
        }
        public void Print(Engineer a)
        {
            Console.WriteLine("Develops new machines");
        }
    }
    public class President : Worker
    {
    }
    public class Security : Worker
    {
    }
    public class Manager : Worker
    {
    }
    public class Engineer : Worker
    {
    }
}
