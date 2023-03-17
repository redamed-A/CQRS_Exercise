using AutoMapper;
using PaymentGateway.Responses;
using PaymentGatewayModel;

namespace PaymentGateway.Mapping
{
    public class PaymentProfile: Profile
    {

        public PaymentProfile()
        {
            CreateMap<Payment, PaymentTransactionResponse>();
            CreateMap<Payment, PaymentsDetails>();
        }
    }
}
