using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendBoilerplate.Data;
using BackendBoilerplate.Models;

namespace BackendBoilerplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExampleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExampleModel>>> GetExamples()
        {
            return await _context.ExampleModels.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ExampleModel>> PostExample(ExampleModel example)
        {
            _context.ExampleModels.Add(example);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetExamples), new { id = example.Id }, example);
        }
    }
}