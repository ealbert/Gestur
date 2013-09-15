﻿using System.Runtime.Serialization;

namespace Gestur.Core.Message
{
  [DataContract]
  public class BusinessWarning
  {
    public BusinessWarning() { }
    public BusinessWarning(BusinessWarningEnum warningType, string message)
    {
      ExceptionType = warningType;
      Message = message;
    }

    [DataMember]
    public BusinessWarningEnum ExceptionType { get; private set; }
    [DataMember]
    public string Message { get; private set; }
  }
}