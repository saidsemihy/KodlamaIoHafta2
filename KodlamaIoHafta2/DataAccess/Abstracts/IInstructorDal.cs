using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor Instructor);
        List<Instructor> GetAll();
        void Update(Instructor Instructor);
        void Delete(Instructor Instructor);
    }
}
