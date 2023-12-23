using Lms.Domain.Common;
namespace Lms.Domain.Entities
{
    public class Group : Auditable, IDeletable
    {
        public Group()
        {
            Lessons = new HashSet<Lesson>();
            StudentGroups = new HashSet<StudentGroup>();
        }

        Guid TeacherId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }     
        
        public User? Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
