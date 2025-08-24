using Microsoft.AspNetCore.Identity;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation property

        public List<Order> Orders { get; set; } = new List<Order>();
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}