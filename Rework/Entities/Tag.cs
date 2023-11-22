using Entities.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tag : BaseEntity<Guid>
    {
        public string Name {  get; set; }
        public string Code {  get; set; }
        public virtual ICollection<ProductTagMap> ProductTagMaps { get; }

    }
}
