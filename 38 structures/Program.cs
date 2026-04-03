using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _38_structures
{
    internal class Program
    {
        //structure: allow to store diff data types into 1 datatype

        struct Person //create a new data type called person
        {
            public string name;
            public int age;
            public string birthMonth;

            public Person(string name, int age, string birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }

        static void Main(string[] args)
        {
            /*
            Person person;

            person.name = "llhm";
            person.age = 26;
            person.birthMonth = "Sept";

            Console.WriteLine($"{person.name} - {person.age} - birth Month is {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            string newBirthMonth = "";

            ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
            Console.WriteLine($"{newName} - {newAge} - birth Month is {newBirthMonth}");
            */

            Person person = ReturnPerson();

            Console.WriteLine($"{person.name} - {person.age} - birth Month is {person.birthMonth}");

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.Write("enter name: ");
            string name = Console.ReadLine();

            Console.Write("enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter birthMonth: ");
            string birthMonth = Console.ReadLine();

            return new Person(name, age, birthMonth);
        }

        /*static void ReturnPerson(ref string name, ref int age, ref string birthMonth)
        {
            Console.Write("enter name: ");
            name = Console.ReadLine();

            Console.Write("enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter birthMonth: ");
            birthMonth = Console.ReadLine();
        }
        */
    }
}
