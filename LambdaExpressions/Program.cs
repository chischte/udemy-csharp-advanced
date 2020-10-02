using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(7));

            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine(squareLambda(11));

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));
       
        }
        static int Square(int number)
        {
            return number * number;
        }
    }
}
