using HomeWork.DataAccess.Abstract;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete()
        {
            _categoryDal.Delete();
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove()
        {
            _categoryDal.Remove();
        }

        public void Update()
        {
            _categoryDal.Update();
        }
    }
}
