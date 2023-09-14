using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_2
{
    public class MusicalInstrument
    {

        public string sound;
        public string name;
        public string desc;
        public string history;

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

        public void History()
        {
            Console.WriteLine(history);

        }
    }
    public class Violin : MusicalInstrument
    {
        public Violin()
        {
            this.sound = "zing zing";
            this.desc = "A string instrument that is played with a bow";
            this.name = "Violin";
            this.history = "Invented in the 16th century in Italy";
        }
    }
    public class Trombone : MusicalInstrument
    {
        public Trombone()
        {
            this.sound = "Wah wah wah";
            this.desc = "A brass instrument";
            this.name = "Trombone";
            this.history = "Invented in the 15th century in Germany";
        }
    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele()
        {
            this.sound = "Warble";
            this.desc = "A stringed instrument that you play with your fingers";
            this.name = "Ukulele";
            this.history = "Invented in 1879 in Hawaii";
        }
    }
}
