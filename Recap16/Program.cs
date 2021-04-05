using System;

namespace Recap16
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = 21;
            double day = 1;
            double week = 6;

            bool sleepsWellAtNight = true;


            string greeting = "Hello Mars!";

            int[] numbers = new int[5];

            
            age++;

            ++age;

            Console.WriteLine(age);


            int month = 7;
            int num2 = 10;

            bool myVariable = month != num2 && num2 % 2 == 0;


            string summerGreeting = month > 6 && month < 9 ? "It is summer" : "It is not summer";

            Console.WriteLine(summerGreeting);
        }
    }
}
