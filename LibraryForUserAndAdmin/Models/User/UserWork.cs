namespace PZ_ASP_UnitOfWorks.Models.User
{
    public class UserWork : IDisposable
    {
        protected HostContext hostContext;
        protected UserRepo userRepo;
        public UserRepo UserRepo
        {
            get
            {
                if (userRepo == null) userRepo = new UserRepo(hostContext);
                return userRepo;
            } 
        }
        public UserWork()
        {
            hostContext = new HostContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
