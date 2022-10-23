using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Models.Admin
{
    public class AdminWork : IDisposable
    {
        HostContext hostContext;
        AdminRepo adminRepo;
        public AdminRepo AdminRepo
        {
            get
            {
                if (adminRepo == null) adminRepo = new AdminRepo(hostContext);
                return adminRepo;
            }
        }
        public AdminWork()
        {
            hostContext = new HostContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
