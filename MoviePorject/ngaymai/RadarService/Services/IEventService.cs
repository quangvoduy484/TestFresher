using RadarWebModels.Models;
using RadarWebService.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Services
{
  public interface IEventService
  {
    Task<BaseResponse> SaveEventByWebHook(EventPosition entry);
    Task<BaseResponse> GetAll();
    Task<BaseResponse> GetById(int id);
    Task<BaseResponse> Remove(int id);
    Task<BaseResponse> Where(Expression<Func<EventModel, bool>> exp);
    
  }
}
