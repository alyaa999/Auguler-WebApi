using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        private readonly TutorialDbContext tutorialDbContext;

        public studentController(TutorialDbContext tutorialDbContext)
        {
            this.tutorialDbContext = tutorialDbContext;
        }
        [HttpGet("listStudents")]
        public IActionResult getStudents()
        {
            var student = tutorialDbContext
                .Students.ToList();
            return Ok(student);
        }
    }
}