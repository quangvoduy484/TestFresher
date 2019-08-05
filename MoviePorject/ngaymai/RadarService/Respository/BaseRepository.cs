using Microsoft.EntityFrameworkCore;
using RadarWebModels.Contexts;
using RadarWebModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Respository
{
  public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
  {

    private readonly DataContext _context;

    private readonly DbSet<T> _entities;

    public BaseRepository(DataContext context)
    {
      _context = context;
      _entities = context.Set<T>();
    
    }
  
    public async Task<IEnumerable<T>> GetAll()
    {
       return await _entities.ToListAsync();
    }

    public async Task<T> GetById(string id)
    {
      return await _entities.SingleOrDefaultAsync(x => x.Id == id);
    }
    
    public IEnumerable<T> Where(Expression<Func<T, bool>> exp)
    {
      return _entities.Where(exp);
    }

    public async void Insert(T entity)
    {
      await _entities.AddAsync(entity);
      _context.SaveChanges();
    }

    public async void Update(T entity)
    {

      var oldEntity = await _context.FindAsync<T>(entity.Id);
      _context.Entry(oldEntity).CurrentValues.SetValues(entity);
      _context.SaveChanges();
    }

    public void Delete(T entity)
    {
      _entities.Remove(entity);
      _context.SaveChanges();
    }

   
  }
}
