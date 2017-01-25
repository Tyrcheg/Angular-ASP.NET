using angpluralmvcempty.Models.Courses;
using angpluralmvcempty.Models.Registration;
using System.Web.Http;
using System.Web.Mvc;

namespace angpluralmvcempty.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationVmBuilder _regVmBuilder = new RegistrationVmBuilder();

        public CourseVm[] Get()
        {
            //System.Threading.Thread.Sleep(5000);
            return _regVmBuilder.GetCoursesVm();
        }
    }
}