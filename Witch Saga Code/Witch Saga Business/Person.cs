
namespace Witch_Saga_Code
{
    public class Person
    {
        public Person(int age, int year)
        {
            this.age = age;
            this.year = year;

            this.birthyear = year - age;
        }
        public int age { get; set; }
        public int year { get; set; }

        public int birthyear { get; set; }



    }
}
