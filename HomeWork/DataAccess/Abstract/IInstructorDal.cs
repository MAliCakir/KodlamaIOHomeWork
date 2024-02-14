using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);

        void Update();

        void Delete();

        void Remove();

        List<Instructor> GetAll();
    }
}
