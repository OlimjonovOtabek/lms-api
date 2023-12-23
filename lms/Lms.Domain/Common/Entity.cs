﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Common
{
    /// <summary>
    /// Базовый класс для сущностей
    /// </summary>
    public abstract class Entity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
