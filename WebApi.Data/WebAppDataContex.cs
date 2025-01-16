using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiTt.Data;

namespace WebApi.Data
{
    public class WebAppDataContex(IConfiguration configuration) : DbContext
    {
        private readonly IConfiguration _configuration = configuration;

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SqlServer"]);
        }
    }
}
