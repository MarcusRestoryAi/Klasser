using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    internal class Person
    {
        //Static list av obejkt av klassen
        public static List<Person> people = new List<Person>();

        private string name1;
        private int age1;

        //Attribut
        public string name { get => name1; set => name1 = value.ToUpper(); }
        public int age { get => age1; set => age1 = value; }

        //Konstruktor
        public Person(string name, int age)
        {
            //Tilldela värden till attributen
            this.name = name;
            this.age = age;

            //Tilldela obejktet till listan people
            Person.people.Add(this);
        }

        //Public metod för Birthdays
        public void Birthday()
        {
            age++;
        }
    }
}
