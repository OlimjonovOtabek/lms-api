using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Common
{
    /// <summary>
    /// Базовый класс для сущностей поддерживающих локализацию 
    /// </summary>
    public abstract class Localizable : Entity, ILocalizable
    {

        /// <summary>
        /// Наименование на узбекском объязательно для заполнение
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Наименование на русском обязательно для заполненние
        /// </summary>
        public string NameRu { get; set; } = default!;

        /// <summary>
        /// Наименование на английском
        /// </summary>
        public string? NameEn { get; set; }

        /// <summary>
        /// Наименование на каракалпакском
        /// </summary>
        public string? NameKa { get; set; }
    }
}
