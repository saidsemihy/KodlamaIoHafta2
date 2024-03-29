using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.Entities
{
    public class Category : BaseEntity
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
    }
}
