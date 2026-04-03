using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_classes
{
    internal class Program
    {
        /*struct Person
        {
            public string name;
            public int age;

            public Person (string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }*/

        //structure: all of the value must be assigned when the structure is created
        //class: can be null

        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        
        static void Main(string[] args)
        {
            Person person = new Person ("llhm", 26);

            //Console.WriteLine($"{person.name}\nAge: {person.age}");
            Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }

        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }

        /*
        static string ReturnDetails(string name, int age)
        {
            return $"{name}\nAge: {age}";
        }
        */
    }
}
