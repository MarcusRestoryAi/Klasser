using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    internal class Person
    {
        //Attribut
        public string name;
        public int age;

        //Konstruktor
        public Person(string name, int age)
        {
            //Tilldela värden till attributen
            this.name = name;
            this.age = age;
        }
    }
}
