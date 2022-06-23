using System;

namespace ExceptionHandlingDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            Console.WriteLine("Please enter a number to divide");
            var userDivide = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number to divide by?");
            var divideBy = int.Parse(Console.ReadLine());

            try
            {
                answer = userDivide / divideBy;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");

            }
            
            finally
            {
                Console.WriteLine("This block will always execute the code");
            }
                Console.WriteLine($"The answer is {answer}");

        }
    }
}
