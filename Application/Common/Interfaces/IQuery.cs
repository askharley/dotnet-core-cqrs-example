using MediatR;

namespace Application.Common.Interfaces
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
        
    }
}