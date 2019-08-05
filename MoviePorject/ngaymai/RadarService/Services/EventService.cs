using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RadarWebModels.Models;
using RadarWebService.Response;

namespace RadarWebService.Services
{
  public class EventService : IEventService
  {
    public IBaseService<Event> _baseEventService;
    public IBaseService<User> _baseUserService;
    public IBaseService<User> _baseGeofencesService;

    public EventService(IBaseService<Event> baseEventService, IBaseService<User> baseUserService, IBaseService<User> baseGeofencesService)
    {
      _baseEventService = baseEventService;
      _baseUserService = baseUserService;
      _baseGeofencesService = baseGeofencesService;

    }
    public Task<BaseResponse> GetAll()
    {
      throw new NotImplementedException();
    }




    public Task<BaseResponse> GetById(int id)
    {
      throw new NotImplementedException();
    }

    public Task<BaseResponse> Remove(int id)
    {
      throw new NotImplementedException();
    }

    public Task<BaseResponse> Where(Expression<Func<EventModel, bool>> exp)
    {
      throw new NotImplementedException();
    }


    public Task<BaseResponse> SaveEventByWebHook(EventPosition entry)
    {
      throw new NotImplementedException();
    }
  }
}
