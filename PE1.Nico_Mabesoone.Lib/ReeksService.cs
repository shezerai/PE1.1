using System;
using System.Collections;
using System.Collections.Generic;

namespace PE1.Nico_Mabesoone.Lib
{
    public class ReeksService
    {


        public static IEnumerable<int> GeefReeks(int min,int max)
        {
            int[] getallen = new int[max];
            while(min <= max)
            {
                getallen[min] = min;
                min++;
            }
            return getallen;
        }
        afsd

        public static IEnumerable<int> GeefReeksEven(int min , int max)
        {
            List<int> getallen = new List<int>();
            while (min <= max)
            {
                if (min%2==0)
                {
                    getallen.Add(min);
                }
                
                min++;
            }
            return getallen;
        }

        

        public  IEnumerable<int> GeefPriemGetallen(int min,int max)
        {
            List<int> getallen = new List<int>();
            while (min <= max)
            {
                if (isPriem(min))
                {
                    getallen.Add(min);
                }
                min++;
            }
            return getallen;
            

        }

        private bool isPriem(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i < number; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }




    }
}
