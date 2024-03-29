using KodlamaIoHafta2.Business.Abstracts;
using KodlamaIoHafta2.DataAccess.Abstracts;
using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.Business.Concrete
{
    public class CourseManager : IGenericService<Course>
    {
     private readonly ICourseDal _courseDal;
    
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
   
        public void Add(Course item)
    {
        _courseDal.Add(item);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Remove(Course item)
    {
        _courseDal.Delete(item);
    }

    public void Update(Course item)
    {
        _courseDal.Update(item);
    }
}
}
