using WebApiTt.Data;

namespace WebApiTt.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync(string name);
    }
}
