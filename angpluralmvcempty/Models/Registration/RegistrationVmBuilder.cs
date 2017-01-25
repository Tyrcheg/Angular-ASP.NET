using angpluralmvcempty.Models.Courses;
using angpluralmvcempty.Models.Instructors;


namespace angpluralmvcempty.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CourseVm[] GetCoursesVm()
        {
            return new[]
            {
                new CourseVm { Number = "1", Name = "Health", Instructor = "Jane" },
                new CourseVm { Number = "2", Name = "Sport", Instructor = "James" },
                new CourseVm { Number = "3", Name = "Computer science", Instructor = "Jhonh" },
                new CourseVm { Number = "4", Name = "Literature", Instructor = "Niga" }
            };
        }

        public InstructorVm[] GetInstructorsVm()
        {
            return new[]
            {
                new InstructorVm {Email = "some@mail.ru", Name = "Health", RoomNumber = 1 },
                new InstructorVm {Email = "some@mail.ru", Name = "Sport", RoomNumber =  4},
                new InstructorVm {Email = "some@mail.ru", Name = "Computer science", RoomNumber =23 },
                new InstructorVm {Email = "some@mail.ru", Name = "Literature", RoomNumber =  51 }
            };
        }

    }

}