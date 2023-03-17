using MediatR;
using PaymentGateway.Responses;
using System.Collections.Generic;

namespace PaymentGateway.Queries
{
    public class GetAllPayments: IRequest<List<PaymentsDetails>>
    {
    }
}
