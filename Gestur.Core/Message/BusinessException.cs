using System;

namespace Gestur.Core.Message
{
  public class BusinessException
    : ApplicationException
  {
    public BusinessException(BusinessExceptionEnum businessExceptionType, string message)
      : base(message)
    {
      ExceptionType = businessExceptionType;
    }

    public BusinessExceptionEnum ExceptionType { get; set; }
  }
}