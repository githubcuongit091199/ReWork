using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Infrastructures
{
    public class BaseEntity<T> : IBaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public BaseEntity() 
        {
            IsActive = true;
            IsDelete = false;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }
    }
}
