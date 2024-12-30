using Microsoft.EntityFrameworkCore;

namespace Trainning.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet

        public DbSet<HangHoa> HangHoa { get; set; }
        #endregion
    }
}
