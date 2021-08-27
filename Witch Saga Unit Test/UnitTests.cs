using NUnit.Framework;
using Witch_Saga_Code;

namespace Witch_Saga_Unit_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void calculateRightAveragePerson()
        {
            Witch w = new Witch();

            Assert.AreEqual(w.averagePerson(1, 3), 2);
    
        }


        [Test]
        public void findNumberofVillagersRight()
        {
            Witch w = new Witch();

            Assert.AreEqual(w.findandCalculateVillagers(5), 12);

        }


        [Test]
        public void TYearofBirth()
        {
            Person person = new Person(13,17);

            Assert.AreEqual(person.birthyear, 4);

        }
    }
}