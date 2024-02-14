using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);

        void Update();

        void Delete();

        void Remove();

        List<Course> GetAll();
    }
}
