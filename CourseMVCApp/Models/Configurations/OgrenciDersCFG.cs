using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseMVCApp.Models.Configurations
{
    /// <summary>
    /// Many to many ilişki tablosu için konfigürasyon sınıfı
    /// </summary>
    public class OgrenciDersCFG : IEntityTypeConfiguration<OgrenciDers>
    {
        public void Configure(EntityTypeBuilder<OgrenciDers> builder)
        {
            builder.HasKey(x => new { x.OgrenciId, x.DersId }); // composite key
        }
    }
}
