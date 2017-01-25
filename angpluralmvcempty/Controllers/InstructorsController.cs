using angpluralmvcempty.Models.Instructors;
using angpluralmvcempty.Models.Registration;
using System.Web.Http;
using System.Web.Mvc;

namespace angpluralmvcempty.Controllers
{
    public class InstructorsController : ApiController
    {
        private readonly RegistrationVmBuilder _regVmBuilder = new RegistrationVmBuilder();

        public InstructorVm[] Get()
        {
            return _regVmBuilder.GetInstructorsVm();
        }
    }
}