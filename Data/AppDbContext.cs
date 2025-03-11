using Luna.Models; // Import model User
using Microsoft.EntityFrameworkCore;

namespace Luna.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor để nhận tham số từ Dependency Injection (DI)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet đại diện cho bảng Users trong database
        public DbSet<User> Users { get; set; }

        // DbSet đại diện cho bảng Products trong database
        public DbSet<Product> Products { get; set; }

        // DbSet đại diện cho bảng Orders trong database
        public DbSet<Order> Orders { get; set; }

        // DbSet đại diện cho bảng OrderDetails trong database
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // Cấu hình đặc biệt (nếu có)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
