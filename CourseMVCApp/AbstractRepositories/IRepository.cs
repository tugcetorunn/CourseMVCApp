namespace CourseMVCApp.AbstractRepositories
{
    /// <summary>
    /// tüm entityler için ortak olan metodları bir kere yazıp diğer repositorylerde kullanabilmek için oluşturuldu
    /// </summary>
    /// <typeparam name="TEntity"> generic olması için </typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> BulAsync(int id);
        Task<ICollection<TEntity>> ListeleAsync();
        Task EkleAsync(TEntity entity);
        Task GuncelleAsync(TEntity entity);
        Task SilAsync(int id);
        Task SaveChangesAsync();
    }
}
