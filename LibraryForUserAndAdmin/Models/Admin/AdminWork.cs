using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Models.Admin
{
    public class AdminWork : UserWork
    {
        public AdminRepo AdminRepo
        {
            get
            {
                if (userRepo == null) userRepo = new AdminRepo(hostContext);
                return (AdminRepo)userRepo;
            }
        }
        public AdminWork() : base() { }
    }
}
