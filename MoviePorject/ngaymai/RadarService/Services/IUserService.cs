using RadarWebModels.Models;
using RadarWebService.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RadarWebService.Services
{
  public interface IUserService
  {
    
    Task<BaseResponse> GetAll();
    Task<BaseResponse> GetById(int id);
    Task<BaseResponse> Remove(int id);
    Task<BaseResponse> Where(Expression<Func<UserModel, bool>> exp);
  }
}
