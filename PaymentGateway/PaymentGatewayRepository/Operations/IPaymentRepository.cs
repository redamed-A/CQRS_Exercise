using PaymentGatewayModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayRepository.Operations
{
    public interface IPaymentRepository
    {
        Task<Payment> ProcessPaymentAsync(string name, string cardNumber, string expiryYear, string expiryMonth, string amount,string currency, string cvv, Guid bankIdTransaction);
        Task<List<Payment>> GetAllPaymentsAsync();
    }
}
