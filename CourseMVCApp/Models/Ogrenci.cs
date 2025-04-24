namespace CourseMVCApp.Models
{
    /// <summary>
    /// Öğrenci için database modelini temsil eder.
    /// </summary>
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }
        public long TCKN { get; set; }
        public ICollection<OgrenciDers>? OgrenciDers { get; set; }
        public ICollection<Yoklama>? Yoklamalar { get; set; }
    }
}
