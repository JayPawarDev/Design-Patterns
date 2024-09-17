using MediatR;

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
