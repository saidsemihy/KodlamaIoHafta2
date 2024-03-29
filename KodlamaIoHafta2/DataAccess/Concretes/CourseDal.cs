using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.DataAccess.Abstracts
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal() 
        { 
            _courses = new List<Course>();
            _courses.Add(new Course { courseId = 1, categoryId = 1, instructorId = 1, courseName = "JavaScript", courseDescription = "Yazılım Geliştirici Kampı", courseImage = "...com" });
            _courses.Add(new Course { courseId = 2, categoryId = 1, instructorId = 1, courseName = ".NET", courseDescription = "Yazılım Geliştirici Kampı", courseImage = "...com" });
        }
        public void Add(Course Course)
        {
            _courses.Add(Course);
        }

        public void Delete(Course Course)
        {
            var courseDelete = _courses.Where(c => c.courseId == Course.courseId).SingleOrDefault();

            if (courseDelete != null)
            {
                _courses.Remove(courseDelete);
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course Course)
        {
            var courseUpdate = _courses.Where(c => c.courseId == Course.courseId).SingleOrDefault();

            if (courseUpdate != null)
            {
                courseUpdate = Course;
            }
        }
    }
}
