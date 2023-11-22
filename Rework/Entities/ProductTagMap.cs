using Entities.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductTagMap : BaseEntity<Guid>
    {
        public Guid ProductId {  get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Guid TagId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
