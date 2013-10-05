using System;

namespace Gestur.Core.Message
{
    public interface ICommandDispatcher
    {
        TResult ExecuteCommand<TService, TResult>(Func<TService, TResult> command)
            where TResult : IDtoResponseEnvelop
            where TService : class;

    }
}