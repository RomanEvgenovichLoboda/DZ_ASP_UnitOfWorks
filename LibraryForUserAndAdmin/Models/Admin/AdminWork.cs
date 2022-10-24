using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Models.Admin
{
    public class AdminWork : UserWork
    {
        new public AdminRepo UserRepo
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
