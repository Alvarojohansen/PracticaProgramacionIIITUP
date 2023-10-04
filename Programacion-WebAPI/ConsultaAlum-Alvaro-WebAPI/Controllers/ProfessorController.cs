
using ConsultaAlum_Alvaro_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaAlum_Alvaro_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;
        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }


        [HttpGet("{idMateria}")]
        public IActionResult GetProfessorxMateria([FromRoute] int idMateria)
        {
           return Ok();
        }
    }
}
