using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sports = new List<string>()
            {
                "football" ,
                "basketboll" ,
                "hentboll" ,
                "badminton",
                "skiing"
            };
            
            foreach (string s in sports)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine();
            //Lambda Expression
            sports.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            Console.WriteLine(new string('*', 20));
            Console.WriteLine();

            var activities = sports;
            activities.ForEach(a => Console.WriteLine(a));
            Console.WriteLine();

            Console.WriteLine(new string('-', 20));

            // add hiking
            sports.Add("hiking");
            sports.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            Console.WriteLine(new string('*', 20));
            Console.WriteLine();

            activities.ForEach(a => Console.WriteLine(a));
            Console.WriteLine();

            Console.WriteLine(new string('-', 20));
            Console.WriteLine();

            //remove football
            activities.Remove("football");
            activities.ForEach(a => Console.WriteLine(a));
            Console.WriteLine();

            Console.WriteLine(new string('*', 20));
            Console.WriteLine();

            sports.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }
    }
}
