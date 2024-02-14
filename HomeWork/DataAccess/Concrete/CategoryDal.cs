using HomeWork.DataAccess.Abstract;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {

            Category category = new Category() { Id = 1, Name = "Courses" };
            Category category1 = new Category() { Id = 2, Name = "Instructors" };
            categories = new List<Category>() { category, category1 };

        }

        public void Add(Category category)
        {
            Console.WriteLine("New Category Added");
        }

        public void Delete()
        {
            Console.WriteLine("New Category Deleted");
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Remove()
        {
            Console.WriteLine("New Category Removed");
        }

        public void Update()
        {
            Console.WriteLine("New Category Updated");
        }

    }
}
