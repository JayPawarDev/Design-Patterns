using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.MediatR
{
    internal class Logger : INotificationHandler<Messenger>
    {
        public async Task Handle(Messenger notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Logging the Message: {notification.Message}");
        }
    }
}
