using AutoMapper.Configuration;
using Core.Models;
using Data.Configuration;
using Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext

    {
        private readonly IConfiguration _config;
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new BlogSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));

        }
    }
}