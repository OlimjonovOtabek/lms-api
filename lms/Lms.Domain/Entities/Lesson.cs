using Lms.Domain.Common;

namespace Lms.Domain.Entities
{
    public class Lesson: Auditable, IDeletable
    {
        public Lesson()
        {
            Attendances = new HashSet<Attendance>();
        }
        public TimeSpan StartDateTime { get; set; }
        public TimeSpan EndDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; } 

        public ICollection<Attendance> Attendances { get; set; }

    }
}
