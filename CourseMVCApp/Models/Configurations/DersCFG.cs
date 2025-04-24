using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Claims;

namespace CourseMVCApp.Models.Configurations
{
    public class DersCFG : IEntityTypeConfiguration<Ders>
    {
        public void Configure(EntityTypeBuilder<Ders> builder)
        {
            builder.Property(x => x.DersAdi).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Aciklama).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Ders()
                {
                    DersId = 1,
                    DersAdi = "C#",
                    Aciklama = "C# Programlama Dili"
                },
                new Ders
                {
                    DersId = 2,
                    DersAdi = "Java",
                    Aciklama = "Java Programlama Dili"
                },
                new Ders
                {
                    DersId = 3,
                    DersAdi = "MSSql",
                    Aciklama = "Veritabanı"
                },
                new Ders
                {
                    DersId = 4,
                    DersAdi = "MVC Core & Identity",
                    Aciklama = "Web Programlama"
                },
                new Ders
                {
                    DersId = 5,
                    DersAdi = "API",
                    Aciklama = "İletişim ve veri analizi"
                });
        }
    }
}
