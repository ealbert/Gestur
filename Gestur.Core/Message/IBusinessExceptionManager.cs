namespace Gestur.Core.Message
{
    public interface IBusinessExceptionManager
    {
        void HandleBusinessException(BusinessExceptionDto exceptionDto);
    }
}
