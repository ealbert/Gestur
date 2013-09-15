using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Gestur.Client.Common.Message
{
  public class DataErrorInfo<T>
    : IDataErrorInfo where T : class
  {
    private readonly T _implementorInstance;
    private Dictionary<string, Func<T, object>> _propertyGetterMap;
    private Dictionary<string, ValidationAttribute[]> _validatorMap;
    private bool _hasInitialisedValidator;

    public DataErrorInfo(T implementator)
    {
      _implementorInstance = implementator;
    }

    #region Implementation of IDataErrorInfo

    public string this[string propertyName]
    {
      get
      {
        if (!_hasInitialisedValidator) InitialiseValidators();
        if (_propertyGetterMap.ContainsKey(propertyName))
        {
          var propertyValue = _propertyGetterMap[propertyName](_implementorInstance);
          var errorMessages = _validatorMap[propertyName]
              .Where(v => !v.IsValid(propertyValue))
              .Select(v => v.ErrorMessage).ToArray();

          return string.Join(Environment.NewLine, errorMessages);
        }

        return string.Empty;
      }
    }

    public string Error
    {
      get
      {
        if (!_hasInitialisedValidator) InitialiseValidators();
        var errors = from validator in _validatorMap
                     from attribute in validator.Value
                     where !attribute.IsValid(_propertyGetterMap[validator.Key](_implementorInstance))
                     select attribute.ErrorMessage;

        return string.Join(Environment.NewLine, errors.ToArray());
      }
    }

    private void InitialiseValidators()
    {
      _hasInitialisedValidator = true;
      _validatorMap = _implementorInstance.GetType()
          .GetProperties()
          .Where(p => GetValidations(p).Length != 0)
          .ToDictionary(p => p.Name, GetValidations);

      _propertyGetterMap = _implementorInstance.GetType()
          .GetProperties()
          .Where(p => GetValidations(p).Length != 0)
          .ToDictionary(p => p.Name, GetValueGetter);
    }

    private static ValidationAttribute[] GetValidations(PropertyInfo property)
    {
      return (ValidationAttribute[])property.GetCustomAttributes(typeof(ValidationAttribute), true);
    }

    private static Func<T, object> GetValueGetter(PropertyInfo property)
    {
      return viewmodel => property.GetValue(viewmodel, null);
    }

    #endregion Implementation of IDataErrorInfo
  }
}
