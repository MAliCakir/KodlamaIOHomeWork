using HomeWork.DataAccess.Abstract;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor() { Id = 1, FirstName = "Engin", LastName = "DEMİROĞ", Courses = new List<Course>().Where(c => c.Author == "Engin DEMİROĞ").ToList() };
            Instructor instructor2 = new Instructor() { Id = 2, FirstName = "Halit", LastName = "KALAYCI", Courses = new List<Course>().Where(c => c.Author == "Halit Enes KALAYCI").ToList() };
            instructors = new List<Instructor>() { instructor1,instructor2};
        }

        public void Add(Instructor instructor)
        {
            Console.WriteLine("Instructor Added");
        }

        public void Delete()
        {
            Console.WriteLine("Instructor Deleted");
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Remove()
        {
            Console.WriteLine("Instructor Removed");
        }

        public void Update()
        {
            Console.WriteLine("Instructor Updated");
        }
    }
}
