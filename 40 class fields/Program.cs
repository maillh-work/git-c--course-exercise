using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_class_fields
{
    internal class Program
    {
        class Person
        {
            private string name; 
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void setName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            /*{
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }*/

            public string getName() => name;
            /*{
                return name;
            }*/

            public void SetAge(int age) => this.age = age > 0 && age <= 150 ? age : -1;

            public int getAge() => age;

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("llhm", 26);
            Console.WriteLine(person.ReturnDetails());

            person.setName("");
            person.SetAge(0);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.getName()} and your age is {person.getAge()}");

            Console.ReadLine();
        }
    }
}
