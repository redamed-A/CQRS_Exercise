using Microsoft.EntityFrameworkCore;
using PaymentGatewayModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayRepository.DbContexts
{
    public class PaymentDbContext: DbContext
    {
        public DbSet<Payment> Payment { get; set; }
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {

        }
    }
}
