using KodlamaIoHafta2.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.Entities
{
    public class Instructor:BaseEntity
    {
        public int instructorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string photo { get; set; }

        public List<Course> Courses { get; set; }
    }
}
