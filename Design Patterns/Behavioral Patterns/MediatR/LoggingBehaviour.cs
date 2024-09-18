using MediatR;

namespace Design_Patterns.Behavioral_Patterns.MediatR;

internal class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Handling {typeof(TRequest).Name}\n");
        var response = await next();
        Console.WriteLine($"Handled {typeof(TResponse).Name}\n");
        return response;
    }
}
