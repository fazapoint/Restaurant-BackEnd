using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Menu : EntityBase
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public bool IsAvailable { get; set; }

        // Navigation property
        public virtual Category Category { get; set; }
    }
}