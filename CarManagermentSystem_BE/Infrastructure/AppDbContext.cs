using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ImageBlog> ImageBlogs { get; set; }
        public DbSet<AddressToShip> AddressToShips { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ImageCar> ImageCars { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Origin> Origins { get; set; }
        public DbSet<GiftCar> GiftCars { get; set; }
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
