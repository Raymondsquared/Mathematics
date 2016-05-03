using System;
using System.Runtime.InteropServices;
using Mathematics.Domain.Service.Interfaces;
using Mathematics.Infrastructure.CrossCutting;
using Mathematics.Infrastructure.Implementations;
using Mathematics.Infrastructure.Interfaces;

namespace Mathematics.Domain.Service.Services
{
    public class FibonacciService : IOperationHandler
    {
        private readonly IFibonacciImplementation _fibonacciImplementation;
        public FibonacciService()
        {
            _fibonacciImplementation = new IterativeFibonacciImplementation();
        }        
        
        public object Do(object input)
        {
            var nullableIntInput = input as int?;
            if (nullableIntInput != null)
            {
                var intInput = (int) nullableIntInput;
                var isNegative = intInput < 0;
                var canBeDevidedByTwo = intInput % 2 == 0;
                var absoluteInput = Math.Abs(intInput);

                if (absoluteInput > Constants.MAX_LONG_FIBONACCI)
                {
                    throw new ArgumentOutOfRangeException("Invalid input - greater than limit");
                }

                var result = _fibonacciImplementation.Fibonacci(absoluteInput);
                if (isNegative && canBeDevidedByTwo)
                {
                    result *= -1;
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Invalid input - unknown");
            }
               
            return null;
        }
    }
}
