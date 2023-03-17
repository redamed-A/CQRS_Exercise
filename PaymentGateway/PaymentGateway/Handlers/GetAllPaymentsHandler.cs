using AutoMapper;
using MediatR;
using PaymentGateway.Queries;
using PaymentGateway.Responses;
using PaymentGatewayService;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Handlers
{
    public class GetAllPaymentsHandler : IRequestHandler<GetAllPayments, List<PaymentsDetails>>
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;
        public GetAllPaymentsHandler(IPaymentService paymentService, IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }
        public async Task<List<PaymentsDetails>> Handle(GetAllPayments request, CancellationToken cancellationToken)
        {
            var payments = await _paymentService.GetAllPaymentsAsync();
            return _mapper.Map<List<PaymentsDetails>>(payments);
        }
    }
}
