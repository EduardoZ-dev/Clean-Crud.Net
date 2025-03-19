using Application.Customers.Common;
using ErrorOr;
using MediatR;

namespace Application.Customers.GetById
{
    public record class GetCustomerByIdQuery(Guid Id) : IRequest<ErrorOr<CustomerResponse>>;    
    
}
