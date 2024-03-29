using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course Course);
        List<Course> GetAll();
        void Update(Course Course);
        void Delete(Course Course);
    }
}
