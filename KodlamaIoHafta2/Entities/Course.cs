using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.Entities
{
    public class Course : BaseEntity
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public string courseImage { get; set; }
        //kurs bir kategoriya ait
        public int categoryId { get; set; }
        //kurs bir eğitmene ait
        public int instructorId { get; set; }
    }
}
