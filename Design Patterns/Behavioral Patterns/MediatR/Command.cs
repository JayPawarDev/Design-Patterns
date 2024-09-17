using MediatR;

namespace Design_Patterns.Behavioral_Patterns.MediatR
{
    internal class Command : IRequest
    {
        public Command(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }
    }
}
