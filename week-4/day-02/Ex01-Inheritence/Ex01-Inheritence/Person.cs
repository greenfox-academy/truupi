﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Inheritence
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string name = "John Doe", int age = 30, string gender = "male")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine(string.Format("Hi, I'm {0}, a {1} year old {2}.", name, age, gender));
        }

        public void GetGoal()
        {
            Console.WriteLine(string.Format("My goal is: Live for the moment!"));
        }
    }
}
