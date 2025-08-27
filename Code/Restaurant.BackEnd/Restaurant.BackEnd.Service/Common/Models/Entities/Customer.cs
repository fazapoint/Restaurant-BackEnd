using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Customer : EntityBase
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
    }
}