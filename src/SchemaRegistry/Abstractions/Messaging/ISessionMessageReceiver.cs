using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MarshmallowPie.Messaging
{
    public interface ISessionMessageReceiver<TMessage> where TMessage : ISessionMessage
    {
        Task<IAsyncEnumerable<TMessage>> SubscribeAsync(CancellationToken cancellationToken);
    }
}