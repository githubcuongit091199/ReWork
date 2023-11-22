using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Infrastructures
{
    public interface IBaseEntity
    {
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        bool IsActive { get; set; }
        bool IsDelete {  get; set; }
    }
}
