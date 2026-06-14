using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
