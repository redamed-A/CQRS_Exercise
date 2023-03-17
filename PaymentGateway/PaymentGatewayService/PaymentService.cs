using PaymentGatewayModel;
using PaymentGatewayRepository.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayService
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Task<List<Payment>> GetAllPaymentsAsync()
        {
            return _paymentRepository.GetAllPaymentsAsync();
        }

        public Task<Payment> ProcessPaymentAsync(string name, string cardNumber, string expiryYear, string expiryMonth, string amount, string cvv, string currency)
        {
            var isPaymentSuccessful = BankProcess(cardNumber, out Guid bankIdTransaction);

            if (isPaymentSuccessful)
                return _paymentRepository.ProcessPaymentAsync(name, cardNumber, expiryYear, expiryMonth, amount, currency, cvv, bankIdTransaction);

            return null;
        }

        private bool BankProcess(string cardNumber, out Guid bankIdTransaction)
        {
            bankIdTransaction = Guid.NewGuid();
            return true;
        }
    }
}
