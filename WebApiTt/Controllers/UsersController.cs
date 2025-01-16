using Microsoft.AspNetCore.Mvc;
using WebApiTt.Data;
using WebApiTt.Interfaces;

namespace WebApiTt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(IUserRepository userRepository) : ControllerBase
    {
        private readonly IUserRepository _userRepository = userRepository;

        [HttpGet]
        public async Task<IEnumerable<User>> Get([FromQuery] string userName)
        {
            return await _userRepository.GetUsersAsync(userName);
        }
    }
}
