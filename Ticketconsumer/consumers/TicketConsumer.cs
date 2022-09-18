using MassTransit;
using shared.Models;
using System.Threading.Tasks;

namespace TicketConsumer.consumers
{
    
        public class TicketConsumer : IConsumer<Ticket>
        {
            public Task Consume(ConsumeContext<Ticket> context)
            {
                var data = context.Message;
                return Task.FromResult<object>(data);
            }
        }
    }

