using RadarWebModels.Models;
using RadarWebService.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Services
{
  public class UserService:IUserService
  {
    private readonly IBaseService<User> _service;

 
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

    public Task<BaseResponse> Where(Expression<Func<UserModel, bool>> exp)
    {
      throw new NotImplementedException();
    }
  }
}
