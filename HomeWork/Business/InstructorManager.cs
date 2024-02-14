using HomeWork.DataAccess.Abstract;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork.Business
{
    internal class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
        
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
        public void Remove() { _instructorDal.Remove(); }
        public void Update() {  _instructorDal.Update(); }
        public void Delete() {  _instructorDal.Delete(); }
    }
}
