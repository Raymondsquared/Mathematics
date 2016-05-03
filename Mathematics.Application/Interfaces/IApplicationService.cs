using Mathematics.Domain.Model;
using Mathematics.Domain.Service.Interfaces;

namespace Mathematics.Application.Interfaces
{
    public interface IApplicationService
    {
        IOperationHandler GetHandler(MathematicsFunctions function);
    }
}
