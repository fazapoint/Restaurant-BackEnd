using Restaurant.BackEnd.Service.Common.Contracts;
using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Order : EntityBase
    {
        public Guid CustomerId { get; set; }
        public Guid WaiterId { get; set; }
        public Guid TableId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        // Navigation property


    }
}