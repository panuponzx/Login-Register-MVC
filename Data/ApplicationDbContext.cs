using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } // เพิ่ม DbSet<User> นี้

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // สามารถกำหนดคอนฟิกเพิ่มเติมได้ตามที่ต้องการ
    }
}
