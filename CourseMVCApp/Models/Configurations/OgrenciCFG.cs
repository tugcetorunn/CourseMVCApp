using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseMVCApp.Models.Configurations
{
    public class OgrenciCFG : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.Property(x => x.OgrenciAdi).HasMaxLength(30).IsRequired();
            builder.Property(x => x.OgrenciSoyadi).HasMaxLength(30).IsRequired();
            builder.Property(x => x.TCKN).HasMaxLength(11).IsRequired();

        }
    }
}
