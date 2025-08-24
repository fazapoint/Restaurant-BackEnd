namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Order : EntityBase
    {
        public Guid CustomerId { get; set; }
        public Guid WaiterId { get; set; }
        public Guid TableId { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation property


    }
}