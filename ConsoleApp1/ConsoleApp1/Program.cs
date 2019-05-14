using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Al = new Animal("", "");
            Console.WriteLine("*********** task 1 **************");
            Console.WriteLine("please enter the animals name");
            Al.Name = Console.ReadLine();
            Console.WriteLine("please enter the animal sound");
            Al.Sound = Console.ReadLine();

            Console.WriteLine("\n" + A1.AnimalSays());

            Console.ReadLine();

            Console.WriteLine("*********** task 1 ************");
            Console.WriteLine("please enter the animal name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter the aniumal sound");
            string sound = Console.ReadLine();
            Animal A2 = new Animal(name, sound);
            Console.WriteLine("\n" + A2.AnimalSays());

            Console.ReadLine();
        }
    }

    class Animal
    {
        string name;
        string sound;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
         public string AnimalSays()
        {
            return $"The{Name} says {Sound}";
        }
        public Animal( string _name, string _sound)
        {
            Name = _name;
            Sound = _sound;
        }
    }
}
