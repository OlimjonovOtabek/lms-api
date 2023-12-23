using Lms.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentGroup : Auditable
    {
        Guid StudentId { get; set; }
        public Guid GroupId { get; set; }
        public DateTimeOffset  JoinedDate {get; set;}
        public bool IsPayed { get; set;}
        public Student Student { get; set; }
        public Group Group {  get; set; }

}

}
