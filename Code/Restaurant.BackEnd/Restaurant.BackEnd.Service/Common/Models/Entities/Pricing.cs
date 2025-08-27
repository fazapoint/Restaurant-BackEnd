using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Pricing : EntityBase
    {
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Guid MenuId { get; set; }
    }
}