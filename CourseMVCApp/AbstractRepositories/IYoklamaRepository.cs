using CourseMVCApp.Models;

namespace CourseMVCApp.AbstractRepositories
{
    public interface IYoklamaRepository : IRepository<Yoklama>
    {
        // Buraya yoklama sınıfına özel metotlar ekleyebiliriz.
        // Yoklama alındığında yoklama kaydını güncelleyen bir metot ekleyebiliriz.
    }
}
