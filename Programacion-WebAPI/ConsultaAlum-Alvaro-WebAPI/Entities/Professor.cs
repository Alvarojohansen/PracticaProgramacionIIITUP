namespace ConsultaAlum_Alvaro_WebAPI.Entities
{
    public class Professor
    {
        public  ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
