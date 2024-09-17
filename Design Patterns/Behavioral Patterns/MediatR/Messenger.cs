using MediatR;

namespace Design_Patterns.Behavioral_Patterns.MediatR
{
    internal class Messenger : INotification
    {
        public Messenger(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
