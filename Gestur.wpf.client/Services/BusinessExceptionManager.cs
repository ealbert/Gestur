using Gestur.Core.Message;
using Gestur.Core.Wpf.Exceptions;
using Gestur.wpf.client.ExceptionNotifier.ViewModel;

namespace Gestur.wpf.client.Services
{
    class BusinessExceptionManager
        :IBusinessExceptionManager
    {
        public void HandleBusinessException(BusinessExceptionDto exceptionDto)
        {
// ReSharper disable ObjectCreationAsStatement
            new ExceptionNotifierViewModel(exceptionDto);
// ReSharper restore ObjectCreationAsStatement
            throw new SuspendProcessException();
        }
    }
}
