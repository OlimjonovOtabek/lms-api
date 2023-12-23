using Lms.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Attendance:Auditable
    {
        public Guid LessonId { get; set; }
        public Guid StudentId { get; set; }

        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
        public bool IsParticipated { get; set; }


        
    }
}
