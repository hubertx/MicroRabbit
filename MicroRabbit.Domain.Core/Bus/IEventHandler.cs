using System;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<in TEvent>: IAsyncDisposable, IEventHandler
        where TEvent: Event
    {
        Task handle(TEvent @event);
    }
    /// <summary>
    /// 
    /// </summary>
    public interface IEventHandler
    {
    }
}
