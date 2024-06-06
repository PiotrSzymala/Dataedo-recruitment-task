using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dataedo_recruitment_task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateoApiController : ControllerBase
    {
        [HttpPost("delete/{id}")]
        public void Delete(uint id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            Debug.WriteLine($"The user with Login={user.login} has been deleted.");
            return Ok();
        }
    }
}
