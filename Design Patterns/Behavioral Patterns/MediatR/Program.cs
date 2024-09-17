using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Design_Patterns.Behavioral_Patterns.MediatR;

internal class Program
{
    public static void Main(string[] args)
    {

        var services = new ServiceCollection();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        var provider = services.BuildServiceProvider();
        var _mediator = provider.GetRequiredService<IMediator>();

         _mediator.Send(new Command(4));

        var message = new Messenger("An event has occurent");

        _mediator.Publish(message);


    }
}
