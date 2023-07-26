using Dotnet.Homeworks.Infrastructure.Cqrs.Utils;
using MediatR;

namespace Dotnet.Homeworks.Infrastructure.Cqrs.Queries;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    public Result<TResponse> Result { get; set; }
}