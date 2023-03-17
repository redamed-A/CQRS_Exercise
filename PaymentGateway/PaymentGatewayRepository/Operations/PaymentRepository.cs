using PaymentGatewayModel;
using PaymentGatewayRepository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGatewayRepository.Operations
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDbContext _db;

        public PaymentRepository(PaymentDbContext db)
        {
            _db = db;
        }

        public Task<List<Payment>> GetAllPaymentsAsync()
        {
            return Task.FromResult(_db.Payment.ToList());
        }

        public Task<Payment> ProcessPaymentAsync(string name, string cardNumber, string expiryYear, string expiryMonth, string amount, string currency, string cvv, Guid bankIdTransaction)
        {
            var payment = new Payment
            {
                PaymentId = Guid.NewGuid(),
                CardNumber = cardNumber,
                ExpiryYear = expiryYear,
                ExpiryMonth = expiryMonth,
                Amount = amount,
                Currency = currency,
                Cvv = cvv,
                BankIdTransaction = bankIdTransaction,
                IsStatusPaymentSuccessful = true,
                Name = name
            };
            _db.Payment.Add(payment);
            _db.SaveChanges();
            return Task.FromResult(payment);
        }
    }
}
