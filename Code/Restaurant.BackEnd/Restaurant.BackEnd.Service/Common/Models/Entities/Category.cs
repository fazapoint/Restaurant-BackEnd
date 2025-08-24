namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        // Navigation property
        public virtual List<Menu> Menus { get; set; } = new List<Menu>();
    }
}