namespace CourseMVCApp.Models
{
    /// <summary>
    /// Yoklama için database modelini temsil eder.
    /// </summary>
    public class Yoklama
    {
        public int YoklamaId { get; set; }
        public DateTime Tarih { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci? Ogrenci { get; set; }
    }
}