using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Common
{
    internal class Auditable : Entity, IAuditable
    {
        /// <summary>
        /// Запись создан в 
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Запись обновлен в
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Запис создан кем
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Запис обновлен кем
        /// </summary>
        public Guid UpdatedBy { get; set; }
    }
}
