using MediatR;

namespace Design_Patterns.Behavioral_Patterns.MediatR
{
    internal class EventBroadcaster : INotificationHandler<Messenger>
    {
        public async Task Handle(Messenger notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Broadcast the Message: {notification.Message}");
        }
    }
}
