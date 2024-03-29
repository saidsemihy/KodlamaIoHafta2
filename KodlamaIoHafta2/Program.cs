using KodlamaIoHafta2.Business.Concrete;
using KodlamaIoHafta2.DataAccess.Abstracts;
using KodlamaIoHafta2.Entities;

namespace KodlamaIoHafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(categories[i].categoryName + " / " + categories[i].description);
            }

            Instructor instructor1 = new Instructor();
            instructor1.instructorId = 1;
            instructor1.firstName = "Murat";
            instructor1.lastName = "Yılmaz";
            instructor1.photo = "..png";
            
            Course course1 = new Course();
            course1.courseId = 1;
            course1.categoryId = 1;
            course1.courseName = "PHP";
            course1.courseImage = "..png";
            course1.courseDescription = "Temel seviye PHP kodlama";

            BaseEntity[] baseEntities = { instructor1, course1 };
            foreach (BaseEntity item in baseEntities)
            {
                Console.WriteLine(baseEntities.ToList());
            }
        }
    }
}
