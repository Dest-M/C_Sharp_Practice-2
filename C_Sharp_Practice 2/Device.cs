using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_2
{
    public class Device
    {
        public string sound;
        public string name;
        public string desc;

        public void Sound()
        {
            Console.WriteLine(sound);

        }
        public void Show()
        {
            Console.WriteLine(name);

        }
        public void Desc()
        {
            Console.WriteLine(desc);

        }
    }
    public class Kettle : Device
    {
        public Kettle()
        {
            this.sound = "blubblub";
            this.desc = "Boils water";
            this.name = "Kettle";
        }
    }
    public class Microwave : Device
    {
        public Microwave()
        {
            this.sound = "Mmmmm";
            this.desc = "Heats food";
            this.name = "Microwave oven";
        }
    }
    public class Car : Device
    {
        public Car()
        {
            this.sound = "Wroom Wroom";
            this.desc = "Drives on roads";
            this.name = "Car";
        }
    }
    public class Ferry : Device
    {
        public Ferry()
        {
            this.sound = "Toot toot";
            this.desc = "Sails in sea";
            this.name = "Ferry";
        }
    }
}
