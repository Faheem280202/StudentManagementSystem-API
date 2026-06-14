using SchoolManagementSystem.Domain.Common;

namespace SchoolManagementSystem.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; } = string.Empty;
    }
}
