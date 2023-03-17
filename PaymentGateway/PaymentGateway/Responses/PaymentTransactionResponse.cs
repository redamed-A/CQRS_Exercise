using System;

namespace PaymentGateway.Responses
{
    public class PaymentTransactionResponse
    {
        public bool IsStatusPaymentSuccessful { get; set; }
        public Guid BankIdTransaction { get; set; }
    }
}
