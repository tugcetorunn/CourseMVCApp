using System.ComponentModel.DataAnnotations.Schema;

namespace CourseMVCApp.Models
{
    /// <summary>
    /// Ders için database modelini temsil eder.
    /// </summary>
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<OgrenciDers>? OgrenciDers { get; set; }
        [ForeignKey("Ogretmen")]
        public string? OgretmenId { get; set; }
        public Ogretmen? Ogretmen { get; set; }
    }
}