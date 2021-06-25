using HelloWorld.Models;
using HelloWorld.Utils;
using System;
using System.Globalization;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            //introduce machine first
            IntroduceConsole();

            //store provided date
            var dateOfBirth = AskForUserDOB();
        }

        public static void IntroduceConsole()
        {
            Console.WriteLine("Hello, I am Creezey and I'm very good at guessing your day of birth from your date of birth.");
        }

        public static DateTimeOffset AskForUserDOB()
        {
            Console.WriteLine("Please tell me your date of birth in this format: (" + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + ")");

            var providedDate = Console.ReadLine();

            return DateTimeOffset.Parse(providedDate);
        }
    }
}
