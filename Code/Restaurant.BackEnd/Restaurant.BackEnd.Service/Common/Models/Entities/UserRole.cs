using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class UserRole : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}