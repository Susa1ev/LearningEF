using DataBase.Models.Base;

namespace DataBase.Models
{
    public class Drug : BaseEntity
    {
        public string Name { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual IEnumerable<Manufacturer> Manufacturer { get; set; }
    }
}
