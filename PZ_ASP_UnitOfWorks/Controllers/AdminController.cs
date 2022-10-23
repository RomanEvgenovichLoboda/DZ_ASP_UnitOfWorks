using Microsoft.AspNetCore.Mvc;
using PZ_ASP_UnitOfWorks.Models.Admin;
using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        AdminWork work;
        public AdminController()
        {
            work = new AdminWork();
        }
        [HttpGet("GetAllNotes")]
        public IEnumerable<object> GetAll() => work.AdminRepo.GetAll();
        [HttpGet("GetNoteById")]
        public object GetNoteById(int id) => work.AdminRepo.Get(id);
        [HttpDelete("DellNoteById")]
        public string DellNoteById(int id) => work.AdminRepo.DeleteById(id);
        [HttpPost("AddOneNote")]
        public string AddOneNote(string text)=>work.AdminRepo.PostOneNote(text);
    }
}
