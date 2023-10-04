using ConsultaAlumnos.API.Entities;

namespace ConsultaAlum_Alvaro_WebAPI.Entities
{
    public class Student : User
    {
        public ICollection<Subject> SubjectsAttended { get; set; } = new List<Subject>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
