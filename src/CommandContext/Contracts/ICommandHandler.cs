using System.Threading.Tasks;

namespace NetCoreApi.CommandContext.Contracts
{
    public interface ICommandHandler<TCommand, TResponse>
    {
        TResponse Handle(TCommand command);
        Task<TResponse> HandleAsync(TCommand command);
    }
}
