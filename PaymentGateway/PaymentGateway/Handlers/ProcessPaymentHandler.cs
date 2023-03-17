using AutoMapper;
using MediatR;
using PaymentGateway.Commands;
using PaymentGateway.Responses;
using PaymentGatewayService;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Handlers
{
    public class ProcessPaymentHandler : IRequestHandler<ProcessPaymentCommand, PaymentTransactionResponse>
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;
        public ProcessPaymentHandler(IPaymentService paymentService, IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }
        public async Task<PaymentTransactionResponse> Handle(ProcessPaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = await _paymentService.ProcessPaymentAsync(request.Name, request.CardNumber, request.ExpiryYear, request.ExpiryMonth, request.Amount, request.Cvv, request.Currency);
            return _mapper.Map<PaymentTransactionResponse>(payment);
        }
    }
}
