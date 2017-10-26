using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print 1-100
            for (int i = 1; i <= 100 ; i++)
            {
                //Check if number is divisible by 3 and 5, if true print "FizzBuzz"
                if ((i % 3==0) && (i % 5 ==0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                //Check if number is only divisible by 3, if true print "Fizz"
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //Check if number is only divisible by 5, if true print "Buzz"
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
    }
}
