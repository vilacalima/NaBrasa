using Microsoft.EntityFrameworkCore;

namespace NaBrasa_Service.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<HamburguerMenu> HamburguerMenus { get; set; } = default;
    }
}
