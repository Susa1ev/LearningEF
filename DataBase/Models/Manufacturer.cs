using DataBase.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
