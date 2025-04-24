using Microsoft.AspNetCore.Identity;

namespace CourseMVCApp.Models
{
    /// <summary>
    /// Öğretmen için database modelini temsil eder. Login olup yoklama ekleyecek olan kullanıcılar için kullanılır.
    /// </summary>
    public class Ogretmen : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public ICollection<Ders>? Dersler { get; set; }
    }
}
