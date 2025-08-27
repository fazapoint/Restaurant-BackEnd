using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class OrderDetail : EntityBase
    {
        public Guid OrderId { get; set; }
        public Guid MenuId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }
    }
}