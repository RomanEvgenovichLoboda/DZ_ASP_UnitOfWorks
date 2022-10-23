using Microsoft.AspNetCore.Mvc;

namespace PZ_ASP_UnitOfWorks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:Controller
    {
        Models.User.UserWork work;
        public UserController()
        {
            work = new Models.User.UserWork();
        }
        [HttpGet("GetAllNotes")]
        public IEnumerable<object> GetAll() => work.UserRepo.GetAll();
        [HttpGet("GetNoteById")]
        public object GetNoteById(int id) => work.UserRepo.Get(id);
    }
}
