using Lms.Domain.Common;
using Lms.Domain.Enums;
using System.Collections;
using System.Security.Principal;

namespace Lms.Domain.Entities
{
    public class User : PersonBase, IDeletable
    {
        public User()
        {
            Groups = new HashSet<Group>();
        }
        public string UserName { get; set; } = default!;
        public string PassrodHash { get; set; } = default!;
        public Role Role { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Group> Groups { get; set; }

    }
}
