using Mathematics.Application.Interfaces;
using Mathematics.Domain.Model;
using Mathematics.Domain.Service.Interfaces;
using Mathematics.Domain.Service.Services;

namespace Mathematics.Application.Services
{
    public class ApplicationService : IApplicationService
    {
        public IOperationHandler GetHandler(MathematicsFunctions function)
        {
            switch (function)
            {
                case MathematicsFunctions.Fibonacci:
                    return new FibonacciService();
                default:
                    return null;
            }
        }
    }
}
