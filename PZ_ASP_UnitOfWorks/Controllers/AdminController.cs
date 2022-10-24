using Microsoft.AspNetCore.Mvc;

namespace PZ_ASP_UnitOfWorks.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AdminController : UserController
    {
        Models.Admin.AdminWork work;
        public AdminController()
        {
            work = new Models.Admin.AdminWork();
        }
        [HttpPost("AddOneNote")]
        public string AddOneNote(string text) => work.AdminRepo.PostOneNote(text);
        [HttpDelete("DellNoteById")]
        public string DellNoteById(int id) => work.AdminRepo.DeleteById(id);
    }
}
