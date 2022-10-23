namespace PZ_ASP_UnitOfWorks.Models.User
{
    public interface IUserRepo<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
