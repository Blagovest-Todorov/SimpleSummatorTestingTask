using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Summator summator = new Summator();

            double result = summator.Sum(new double[] { 1, 2, 3, 4, 5, 6});

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
