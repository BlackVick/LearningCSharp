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
            Console.WriteLine("My name is " + firstName + " " + lastName + "\nI am " + age + " years old\nI am " + height + "ft tall and " + weight + "kg in weight.");
        }

    }
}
