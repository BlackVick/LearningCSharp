using HelloWorld.Models;
using System;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.firstName = "Elias";
            user.lastName = "Walker";
            user.age = 27;
            user.weight = 62.7f;
            user.height = 5.11f;

            //introduce user
            user.IntroduceUser();
        }
    }
}
