using Microsoft.EntityFrameworkCore;
using WebApiTt.Data;
using WebApiTt.Interfaces;

namespace WebApi.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly WebAppDataContex _context;

        public UserRepository(WebAppDataContex context) => _context = context;

        public async Task<IEnumerable<User>> GetUsersAsync(string name)
        {
            return await _context.Users.Where(x => x.Name.Contains(name))
                .ToListAsync();
        }
    }
}
