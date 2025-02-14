using MediatR;

namespace Application.Contracts;

public interface ICommand : IAppRequest
{
}

public interface ICommand<out TResult> : IAppRequest<TResult>
{
}