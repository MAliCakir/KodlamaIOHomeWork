using HomeWork.DataAccess.Abstract;
using HomeWork.DataAccess.Concrete;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business
{
    internal class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
       
        public List<Course> GetAll()
        {
           
            return _courseDal.GetAll();
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
        public void Remove()
        {
            _courseDal.Remove();
        }
        public void Update()
        {
            _courseDal.Update();
        }
        public void Delete()
        {
            _courseDal.Delete();
        }
    }
}
