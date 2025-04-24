using CourseMVCApp.AbstractRepositories;
using CourseMVCApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CourseMVCApp.ConcreteRepositories
{
    /// <summary>
    /// IRepository<T> interface ini implement eden ve tüm entityler için ortak olan metodları içeren sınıf. contexti sadece burada dolduruyoruz.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly CourseDbContext context;
        private readonly DbSet<TEntity> dbSet;

        public BaseRepository(CourseDbContext _context)
        {
            context = _context;
            dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> BulAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<ICollection<TEntity>> ListeleAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task EkleAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task GuncelleAsync(TEntity entity)
        {
            dbSet.Update(entity);
            await SaveChangesAsync();
        }

        public async Task SilAsync(int id)
        {
            var entity = await BulAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

    }
}
