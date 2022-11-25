using System;

namespace Uppgift1_morötter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång tid tar det för Tor att äta en morot? Svara i sekunder, mellan 1-100.");
            int torsTid = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur lång tid tar det för mor att äta en morot? Svara i sekunder, mellan 1-100.");
            int morsTid = int.Parse(Console.ReadLine());


        }
    }
}