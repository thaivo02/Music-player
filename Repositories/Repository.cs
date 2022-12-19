using Microsoft.EntityFrameworkCore;
using Muzic.Database;

namespace Muzic.Repositories;

public class Repository<T, TKey> : IRepository<T, TKey>
    where T : AggressiveRoot<TKey>
{
    private readonly ApplicationDbContext _dbContext;

    protected DbSet<T> DbSet => _dbContext.Set<T>();

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public IQueryable<T> GetAll()
    {
        return _dbContext.Set<T>();
    }

    public void Add(T entity)
    {
        _dbContext.Add(entity);
    }

    public void Update(T entity)
    {
        _dbContext.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbContext.Remove(entity);
    }
}