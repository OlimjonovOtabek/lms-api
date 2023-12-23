using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Common
{
    public interface ILocalizable
    {
        string Name { get; set; }
        string NameRu { get; set; }
        string? NameEn { get; set; }
        string? NameKa { get; set; }
    }
}
