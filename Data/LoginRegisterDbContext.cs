using FURNITURE.Models;
using Microsoft.EntityFrameworkCore;

namespace FURNITURE.Data
{
    public class LoginRegisterDbContext : DbContext
    {
        public LoginRegisterDbContext(DbContextOptions<LoginRegisterDbContext> options):base(options)
        {
            
        }
        public DbSet<UserTbl> User_tbl { get; set; }
    }
}
