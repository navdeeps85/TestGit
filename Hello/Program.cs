

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("How many hours did you sleep last night?");
            int HoursOfSleep = int.Parse( Console.ReadLine());
            Console.WriteLine("Hello "+name);

            if (HoursOfSleep > 8)
            {

                Console.WriteLine("You are well rested");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("You need more rest");
            }
            
        }
    }
}
