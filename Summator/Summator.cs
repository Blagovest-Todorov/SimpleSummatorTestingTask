using System;
using System.Collections.Generic;
using System.Text;

namespace Summator
{
    public static class Summator
    {
        public static double Sum(double[] arr) 
        {           
                double sum = 0d;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            
                return sum;         

        }

        public static double ReturnAverageNumberFromArray(double[] arr )
        {           

            double sumOfArrNumbers = Sum(arr);

            if (arr.Length != 0)
            {
                sumOfArrNumbers = Sum(arr);
                return sumOfArrNumbers / arr.Length;
            }
            else
            {
                Console.WriteLine("Array is empty");
                return 0;
            }
        }
    }
}
