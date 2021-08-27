
namespace Witch_Saga_Code
{
    public class Witch
    {
        public int yearStarted { get; set; }

        public double averagePerson(double birthperson1, double birthperson2)
        {
            return ((birthperson1 + birthperson2) / 2);
        }


        public int findandCalculateVillagers(int yr)
        {
            int i = 0;
            int villagers = 0;

            int[] arrayYear = new int[yr];

            if (arrayYear.Length == 1 )
            {
                arrayYear[0] = 1;

            }  else if (arrayYear.Length > 1)
            {
                arrayYear[0] = 1;
                arrayYear[1] = 1;

            }
            while (i < yr)
            {
                if(i > 1)
                {
                    arrayYear[i] = arrayYear[i - 1] + arrayYear[i - 2];
                }

                i++;
            }

            for(int num=0;num < arrayYear.Length; num++)
            {
                villagers += arrayYear[num];
            }

            return villagers;
        }
    }
}
