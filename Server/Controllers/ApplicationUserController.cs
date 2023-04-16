using BWASMAPP.Server.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BWASMAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("userid/{username}")]
        public async Task<ActionResult<string>?> GetUserId()
        {

            var username = HttpContext.Request.RouteValues["username"].ToString();
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
            return user?.Id;
        }

       

    }
}
