using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace C_Sharp_Practice_2
{
    internal class Program
    {
        static void DeviceDisplay(Device a)
        {
            Console.WriteLine("--------------\n");
            a.Show();
            a.Desc();
            a.Sound();
        }
        static void MusicDisplay(MusicalInstrument a)
        {
            Console.WriteLine("--------------\n");
            a.Show();
            a.Desc();
            a.Sound();
            a.History();
        }
        static void DeviceUse()
        {
           Kettle ket = new Kettle();
            Microwave microwave= new Microwave();
            Car car = new Car();
            Ferry fer = new Ferry();
            DeviceDisplay(ket);
            DeviceDisplay(microwave);
            DeviceDisplay(car);
            DeviceDisplay(fer);

        }
        static void MusicUse()
        {
            Violin v = new Violin();
            Trombone t = new Trombone();
            Ukulele u = new Ukulele();
            MusicDisplay(v);
            MusicDisplay(t);
            MusicDisplay(u);
          

        }
        static void MoneyRun()
        {
            Console.WriteLine("Creating new product");
            Product p1 = new Product();
            Console.WriteLine("Display: ");
            p1.display();
            int a, b;
            Console.WriteLine("Enter discount in dollars: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount in cents: ");
            b = Convert.ToInt32(Console.ReadLine());
            p1.discount(a, b);
            Console.WriteLine("Display: ");
            p1.display();

        }
        static void WorkerUse()
        {
            President a = new President();
            Security b = new Security();
            Manager c = new Manager();
            Engineer d = new Engineer();
            Worker use = new Worker();
            use.Print(a);
            use.Print(b);
            use.Print(c);
            use.Print(d);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~QUESTION 1~~~~~~~~~~~~~~~~~~~~~~~~\n");
            MoneyRun();
            Console.WriteLine("\n\n\n~~~~~~~~~~~~~~~~~~~~~~~~QUESTION 2~~~~~~~~~~~~~~~~~~~~~~~~\n");
            DeviceUse();
            Console.WriteLine("\n\n\n~~~~~~~~~~~~~~~~~~~~~~~~QUESTION 3~~~~~~~~~~~~~~~~~~~~~~~~\n");
            MusicUse();
            Console.WriteLine("\n\n\n~~~~~~~~~~~~~~~~~~~~~~~~QUESTION 4~~~~~~~~~~~~~~~~~~~~~~~~\n");
            WorkerUse();

        }
    }
}