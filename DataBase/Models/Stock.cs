using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models.Base;

namespace DataBase.Models
{
    public class Stock : BaseEntity
    {
        public string Name { get; set; }
        public virtual IEnumerable<Drug> Drugs { get; set; }
    }
}
