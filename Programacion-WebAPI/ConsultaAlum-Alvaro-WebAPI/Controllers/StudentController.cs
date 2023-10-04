using ConsultaAlum_Alvaro_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaAlum_Alvaro_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;


        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet("{idStudent}")]
        public IActionResult GetStudentById([FromRoute]int idStudent)
        {
            return Ok();
        }
    }
    
}
