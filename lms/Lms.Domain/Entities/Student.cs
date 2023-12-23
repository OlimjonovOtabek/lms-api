using Lms.Domain.Common;

namespace Lms.Domain.Entities
{
    public class Student : PersonBase, IAuditable
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            StudentGroups = new HashSet<StudentGroup>();
        }
        public string PhoneNumber { get; set; } = default!;
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get ; set ; }

        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
