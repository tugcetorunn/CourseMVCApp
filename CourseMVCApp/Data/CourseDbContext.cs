using CourseMVCApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CourseMVCApp.Data
{
    /// <summary>
    /// Database in oluşması için gerekli olan DbContext sınıfı
    /// </summary>
    public class CourseDbContext : IdentityDbContext<Ogretmen>
    {
        public CourseDbContext()
        {
            
        }

        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
            
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Yoklama> Yoklamalar { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
