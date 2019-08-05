using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebService.Response
{
  public class BaseResponse
  {
    public int ErrorCode { get; set; }
    public string Messege { get; set; }
    public object Data { get; set; }
    public BaseResponse() { }
    public BaseResponse(object data)
    {
      Data = data;
    }
  }
}
