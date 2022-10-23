using Microsoft.AspNetCore.Mvc;

namespace PZ_ASP_UnitOfWorks.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        Models.Admin.AdminWork work;
        public AdminController()
        {
            work = new Models.Admin.AdminWork();
        }
        [HttpGet("GetAllNotes")]
        public IEnumerable<object> GetAll() => work.AdminRepo.GetAll();
        [HttpGet("GetNoteById")]
        public object GetNoteById(int id) => work.AdminRepo.Get(id);
        [HttpPost("AddOneNote")]
        public string AddOneNote(string text) => work.AdminRepo.PostOneNote(text);
        [HttpDelete("DellNoteById")]
        public string DellNoteById(int id) => work.AdminRepo.DeleteById(id);
    }
}
