using System;

namespace Witch_Saga_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(10, 12);
            Person person2 = new Person(13, 17);

            Witch w = new Witch();


            if (person1.birthyear < 0 || person2.birthyear < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("Person A born on Year = " + person1.year + " - " + person1.age + " = " + person1.birthyear + ", number of people killed on year 2 is " + w.findandCalculateVillagers(person1.birthyear));
                Console.WriteLine("Person A born on Year = " + person2.year + " - " + person2.age + " = " + person2.birthyear + ", number of people killed on year 4 is " + w.findandCalculateVillagers(person2.birthyear));


            Console.WriteLine("So the average is (" + w.findandCalculateVillagers(person2.birthyear) + " + " + w.findandCalculateVillagers(person1.birthyear) + ")/2 = " + w.averagePerson(w.findandCalculateVillagers(person1.birthyear), w.findandCalculateVillagers(person2.birthyear)));

            }

            Console.ReadKey();
        }
    }
}
