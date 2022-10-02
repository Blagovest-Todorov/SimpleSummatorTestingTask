using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double result = Summator.Sum(new double[] { 1, 2, 3, 4, 5, 6});

            if (result == 20)
            {
                Console.WriteLine("Test pass");
            }
            else 
            {
                Console.WriteLine("test failed");
            }
        }        
    }
}
