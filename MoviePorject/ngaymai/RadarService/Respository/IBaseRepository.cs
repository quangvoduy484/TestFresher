using RadarWebModels.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Respository
{
  public interface IBaseRepository<T> where T:BaseEntity
  {
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(string id);
    IEnumerable<T> Where(Expression<Func<T, bool>> exp);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);

  }
}
