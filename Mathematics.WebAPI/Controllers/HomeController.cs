using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Mathematics.Application.Interfaces;
using Mathematics.Application.Services;
using Mathematics.Domain.Model;

namespace Mathematics.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IApplicationService _applicationService;
        public HomeController()
        {
            _applicationService = new ApplicationService();
        }

        [Route("api/v1/fibonacci")]
        public long Fibonacci(int input)
        {
            long result = 0;
            try
            {
                var handler = _applicationService.GetHandler(MathematicsFunctions.Fibonacci);
                if (handler != null)
                {
                    result = (long) handler.Do(input);
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                //ignored
            }
            return result;
        }
    }
}
