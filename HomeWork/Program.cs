using HomeWork.Business;
using HomeWork.DataAccess.Concrete;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());

            courseManager.Update();

            var result = courseManager.GetAll().Where(cM => cM.Price == "Free");

            foreach (var cM in result) { Console.WriteLine(cM.Name); }

            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            var result1 = instructorManager.GetAll().Where(iM => iM.Id == 1||iM.Id==2);
            foreach (var iM in result1) { Console.WriteLine("Instructor Name {0} {1}", iM.FirstName, iM.LastName); }

           

            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //var result2 = categoryManager.GetAll().Where(ctM => ctM.Id == 1);
            //foreach (var ctM in result2)
            //{
            //    Console.WriteLine(ctM.Name);
            //}
            Console.ReadLine();


        }
    }
}
