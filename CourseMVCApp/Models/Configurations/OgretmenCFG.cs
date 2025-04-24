using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseMVCApp.Models.Configurations
{
    public class OgretmenCFG : IEntityTypeConfiguration<Ogretmen>
    {
        public void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Soyad).HasMaxLength(30).IsRequired();

            var ogretmen = new Ogretmen
            {
                Id = Guid.NewGuid().ToString(),
                Ad = "Yılmaz",
                Soyad = "Uslu",
                UserName = "yılmazhoca",
                NormalizedUserName = "YILMAZHOCA",
                Email = "yilmazuslu@hotmail.com",
                NormalizedEmail = "YİLMAZUSLU@HOTMAİL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            PasswordHasher<Ogretmen> passwordHasher = new PasswordHasher<Ogretmen>();
            ogretmen.PasswordHash = passwordHasher.HashPassword(ogretmen, "Admin*123");
            builder.HasData(ogretmen);
        }
    }
}
