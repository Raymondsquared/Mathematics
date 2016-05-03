using System;
using Mathematics.Infrastructure.Interfaces;

namespace Mathematics.Infrastructure.Implementations
{
    public class RecursiveFibonacciImplementation : IFibonacciImplementation
    {
        public long Fibonacci(int input)
        {
            if (input <= 1)
            {
                return input;
            }

            return Fibonacci( input - 1 )  + Fibonacci( input - 2);
        }
    }
}
