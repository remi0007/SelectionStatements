using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite schoocl subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {

                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "science":
                    Console.WriteLine("Science is a tough subject!");
                    break;

                case "english":
                    Console.WriteLine("English is a fun subject!");
                    break;

                default:
              
                    Console.WriteLine($" Oh really! I have not taken that subject before. {subject} sounds fun!S");
                    break;
            }
        }
    }
}
