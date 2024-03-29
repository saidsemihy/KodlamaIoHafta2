using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.DataAccess.Abstracts
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors.Add(new Instructor { instructorId = 1, firstName = "Engin", lastName = "Demiroğ", photo = "..com" });
            _instructors.Add(new Instructor { instructorId = 2, firstName = "Said Semih", lastName = "Yalçın", photo = "..com" });
        }
        public void Add(Instructor Instructor)
        {
            _instructors.Add(Instructor);
        }

        public void Delete(Instructor Instructor)
        {
            var instructorDelete = _instructors.Where(c => c.instructorId == Instructor.instructorId).SingleOrDefault();
            if (instructorDelete != null)
            {
                _instructors.Remove(Instructor);
            }

        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor Instructor)
        {
            var instructorUpdate = _instructors.Where(c => c.instructorId == Instructor.instructorId).SingleOrDefault();
            if(instructorUpdate != null)
            {
                instructorUpdate = Instructor;
            }
        }
    }
}
