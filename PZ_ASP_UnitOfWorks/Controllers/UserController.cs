using Microsoft.AspNetCore.Mvc;
using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:Controller
    {
        UserWork work;
        public UserController()
        {
            work = new UserWork();
        }
        [HttpGet("GetAllNotes")]
        public IEnumerable<object> GetAll() => work.UserRepo.GetAll();
        [HttpGet("GetNoteById")]
        public object GetNoteById(int id) => work.UserRepo.Get(id);
    }
}
