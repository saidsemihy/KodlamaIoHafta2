using KodlamaIoHafta2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHafta2.DataAccess.Abstracts
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1= new Category();
            category1.categoryId = 1;
            category1.categoryName = "Programlama";
            category1.description = "Temel seviye";

            _categories= new List<Category> { category1};
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            var categoryDelete = _categories.Where(c=>c.categoryId == category.categoryId).SingleOrDefault();
            
            if (categoryDelete != null)
            {
                _categories.Remove(categoryDelete);
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            var updateCategory = _categories.Where(u=>u.categoryId == category.categoryId).SingleOrDefault();

            if (updateCategory != null)
            {
                updateCategory = category;
            }
        }
    }
}
