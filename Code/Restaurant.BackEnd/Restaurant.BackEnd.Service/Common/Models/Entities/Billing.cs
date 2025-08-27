using Restaurant.BackEnd.Service.Common.Contracts;
using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Billing : EntityBase
    {
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaidAt { get; set; }
        public BillingStatus DocumentStatus { get; set; }
        public Guid CashierId { get; set; }
    }
}