using MediatR;

namespace Design_Patterns.Behavioral_Patterns.MediatR;

internal class CommandHandler : IRequestHandler<Command>
{
    public Task Handle(Command request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Id: {request.Id}");
        return Task.CompletedTask;
    }
}
