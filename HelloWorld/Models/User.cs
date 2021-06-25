using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class User
    {

        public string firstName;
        public string lastName;
        public int age;
        public float height;
        public float weight;

        public void IntroduceUser()
        {
            var aboutMe = string.Format("My name is {0} {1}, \nI am {2} years old. \nI am {3} ft tall and {4} kg in weight", firstName, lastName, age, height, weight);
            Console.WriteLine(aboutMe);
        }

    }
}
