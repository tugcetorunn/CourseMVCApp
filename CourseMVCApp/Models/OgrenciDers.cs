namespace CourseMVCApp.Models
{
    /// <summary>
    /// Öğrenci ve Ders arasındaki ilişkiyi temsil eder. many to many
    /// </summary>
    public class OgrenciDers
    {
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public Ogrenci? Ogrenci { get; set; }
        public Ders? Ders { get; set; }
    }
}