using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }
        
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Professores: Marta, José, Tiago, Maria");
        }
            
        
    }
}