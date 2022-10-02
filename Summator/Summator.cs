using System;
using System.Collections.Generic;
using System.Text;

namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr) 
        {
            // We receive Arithmetic exception when checked is put as a block
            //System.OverflowException : Arithmetic operation resulted in an overflow.
            //checked
            //{
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            
                return sum;
            //}

        }
    }
}
