using RadarWebModels.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Services
{
  public interface IBaseService<T> where T:BaseEntity
  {
    Task<IEnumerable<T>> GetAll();

    Task<T> GetById(string id);

    IEnumerable<T> Where(Expression<Func<T, bool>> exp);

    void AddOrUpdate(T entry);

    void Remove(string id);
  }
}
