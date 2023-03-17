using PaymentGatewayModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayService
{
    public interface IPaymentService
    {
        Task<Payment> ProcessPaymentAsync(string name, string cardNumber, string expiryYear, string expiryMonth, string amount, string cvv, string currency);
        Task<List<Payment>> GetAllPaymentsAsync();
    }
}
