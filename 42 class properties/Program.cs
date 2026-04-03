using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _42_class_properties
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name { get; set; } //use when no need to check any conditon
            public int Age { get; set; }
            /*public string Name
            {
                get => name;
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
            }

            public int Age
            {
                get => age;
                set => age = value > 0 && value <= 150 ? value : -1;
            }*/

            //public string Name { get => name; set => name = value; }
            //public int Age { get => age; set => age = value; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            /*public string ReturnDetails()
            {
                return $"Name: {Name}\tAge: {Age}";
            }*/

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {Age}";
            }

            public override bool Equals(object obj)
            {
               if (obj is Person)
                {
                    Person person = obj as Person;
                    return Name.Equals(person.Name) && Age == person.Age;
                }
               return false ;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("llhm", 26);
            Person test = new Person("harry", 62);

            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            if (person.Equals(test))
            {
                Console.WriteLine("same");
            }
            else Console.WriteLine("diff");
             
            Console.ReadLine();
        }






        /*
           public void setName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

           public string getName() => name;

           public void SetAge(int age) => this.age = age > 0 && age <= 150 ? age : -1;

           public int getAge() => age;
           public string ReturnDetails()
           {
               string test = "";
               return $"Name: {name}\nAge: {age}";
           }*/
    }
}
