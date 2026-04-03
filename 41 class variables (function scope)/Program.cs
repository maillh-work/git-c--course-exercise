using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_class_variables__function_scope_
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            private string test = "hello";

            public Person (string name, int age)
            {
                this.name = name;
                this.age = age;
                //string test = "hi"; //prioritize local var rather than global var
                Console.WriteLine(test);
            }

            public void setName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

            public string getName() => name;

            public void SetAge(int age) => this.age = age > 0 && age <= 150 ? age : -1;

            public int getAge() => age;
            public string ReturnDetails()
            {
                string test = "";
                return $"Name: {name}\nAge: {age}";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("llhm", 26);
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }

        static void something()
        {

        }
    }
}
