using BWASMAPP.Server.Data;
using BWASMAPP.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BWASMAPP.Server.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AnnonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AnnonsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ann = await _context.Annonser.ToListAsync();
            return Ok(ann);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var ann = await _context.Annonser.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(ann);
        }

        [Authorize]
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Annons>>> GetAnnonsByUserId(int userId)
        {
            return await _context.Annonser.Where(x => Convert.ToInt32(x.UserId) == userId).ToListAsync();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(Annons annons)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    annons.UserId = userId;
            _context.Add(annons);
            await _context.SaveChangesAsync();
            return Ok(annons.Id);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Put(Annons annons)
        {
            _context.Entry(annons).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ann = new Annons { Id = id };
            _context.Remove(ann);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
