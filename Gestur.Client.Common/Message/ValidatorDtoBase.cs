using System.ComponentModel;

namespace Gestur.Client.Common.Message
{
  public abstract class ValidatorDtoBase
    : DtoBase, IDataErrorInfo
  {
    private DataErrorInfo<ValidatorDtoBase> _dataErrorValidator;

    #region Implementation of IDataErrorInfo

    public string this[string propertyName]
    {
      get { return GetDataErrorInfo()[propertyName]; }
    }

    public string Error
    {
      get { return GetDataErrorInfo().Error; }
    }

    #endregion

    public bool IsValid()
    {
      return string.IsNullOrEmpty(Error);
    }

    private DataErrorInfo<ValidatorDtoBase> GetDataErrorInfo()
    {
      if (_dataErrorValidator != null) return _dataErrorValidator;
      _dataErrorValidator = new DataErrorInfo<ValidatorDtoBase>(this);
      return _dataErrorValidator;
    }
  }
}