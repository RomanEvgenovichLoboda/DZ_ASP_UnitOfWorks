namespace PZ_ASP_UnitOfWorks.Models.User
{
    public class UserRepo : IUserRepo<Not>
    {
        public HostContext context;
        public UserRepo(HostContext context)
        {
            this.context = context;
        }
        public Not Get(int id) => context.Nots.Find(id);
        public IEnumerable<Not> GetAll() => context.Nots;
    }
}
