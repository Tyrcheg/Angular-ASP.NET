using Newtonsoft.Json;

namespace angpluralmvcempty.Models.Courses
{
    public class CourseVm
    {
        [JsonProperty]
        public string Number { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Instructor { get; set; }

    }

}