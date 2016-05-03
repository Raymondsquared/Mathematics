using System;
using Mathematics.Infrastructure.Interfaces;

namespace Mathematics.Infrastructure.Implementations
{
    public class IterativeFibonacciImplementation : IFibonacciImplementation
    {
        public long Fibonacci(int input)
        {
            int x = 0, y = 1, z = 1;

            for (int i = 0; i < input; i++)
            {
                x = y;
                y = z;
                z = x + y;
            }

            return x;            
        }
    }
}
