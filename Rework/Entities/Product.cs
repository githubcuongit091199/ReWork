using Entities.Infrastructures;

namespace Entities
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ProductTagMap> ProductTagMaps { get; set; }

    }
}