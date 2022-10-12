namespace Klasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initiera ett objekt av Klassen Person
            Person refPerson1 = new Person("Marcus", 34);

            Console.WriteLine(refPerson1.name);
            Console.WriteLine(refPerson1.age);

            refPerson1.name = "Marcus";
            Console.WriteLine(refPerson1.name);

            //Initiera en Array för objekt av klassen Person
            Person[] arrUtbildare = new Person[3];

            arrUtbildare[0] = refPerson1;
            arrUtbildare[1] = new Person("Niklas", 32);
            arrUtbildare[2] = new Person("Cihan", 53);

            //Initiera lista över personer
            List<Person> listPersons = new List<Person>();

            // ForEach loop för att gå igenom arrayen
            foreach(Person personPekareILoop in arrUtbildare)
            {
                //Inkludera objektet till listan av persons
                listPersons.Add(personPekareILoop);

                Console.WriteLine( personPekareILoop.name );
                Console.WriteLine( personPekareILoop.age );
                personPekareILoop.Birthday();
                Console.WriteLine(personPekareILoop.age);
            }

            //Inludera ytterligare obejkt till Lista
            listPersons.Add(new Person("Maria", 42));
            listPersons.Add(new Person("Malin", 31));

            //Deklarera variabel allNames
            string allNames = "";

            foreach (Person personPekareILoop in listPersons)
            {
                //Spara alla namnen i variabel
                allNames += personPekareILoop.name + " ";
            }

            Console.WriteLine("Namnen på alla personer är {0}", allNames);

            //Skapar ett nytt objekt och anropar funktion för att skriva ut statisk lista
            new Person("Person6", 44);
            PrintList();

            //Sök listan och ta bort obejktet Person6
            foreach (Person i in Person.people)
            {
                // If-stats för att kontrollera namnet
                if (i.name == "Person6".ToUpper())
                {
                    //Ta bort objketet och lämna loopen
                    Person.people.Remove(i);
                    break;
                }
            }

            //Anropar funktion för att skriva ut statisk lista
            PrintList();

        }

        public static void PrintList()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Innehållet från den statiska listan:");
            foreach (Person i in Person.people)
            {
                Console.WriteLine(i.name);
            }
        }
    }
}