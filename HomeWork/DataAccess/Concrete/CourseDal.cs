using HomeWork.DataAccess.Abstract;
using HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.DataAccess.Concrete
{

    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {

            Course course1 = new Course() { Id = 1, Name = "2024 Yazılım Geliştirici Yetiştirme Kampı", Description = "C# and .Net framework", Author = new List<Instructor>().Where(i=>i.FirstName=="Engin"&& i.LastName=="DEMİROĞ").ToList(), Price = "Free" };
            Course course2 = new Course() { Id = 2, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı", Description = "C# and .Net", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "DEMİROĞ").ToList(), Price = "Free" };
            Course course3 = new Course() { Id = 3, Name = "Yazılım Geliştirici Yetiştirme Kampı", Description = "C# and Angular", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "DEMİROĞ").ToList(), Price = "Free" };
            Course course4 = new Course() { Id = 4, Name = "2023 Yazılım Geliştirici Yetişrime Kampı", Description = "Phyton and Selenium",Author = new List<Instructor>().Where(i => i.FirstName == "Halit" && i.LastName == "KALAYCI").ToList(), Price = "Free" };
            Course course5 = new Course() { Id = 5, Name = "2022 Yazılım Geliştirici Yetiştirme Kampı", Description = "Java", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "D EMİROĞ").ToList(), Price = "Free" };
            Course course6 = new Course() { Id = 6, Name = "Yazılım Geliştirici Yetiştirme Kampı", Description = "JavaScript", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "DEMİROĞ").ToList(), Price = "Free" };
            Course course7 = new Course() { Id = 7, Name = "Yazılım Geliştirici Yetiştirme Kampı", Description = "Java and React", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "DEMİROĞ").ToList(), Price = "Free" };
            Course course8 = new Course() { Id = 8, Name = "Programlamaya Giriş İçin Temel Kurs", Description = "C# and .Net framework", Author = new List<Instructor>().Where(i => i.FirstName == "Engin" && i.LastName == "DEMİROĞ").ToList(), Price = "Free" };
            courses = new List<Course>() { course1, course2, course3, course4, course5, course6, course7, course8 };
        }
        public List<Course> GetAll()
        {
            return courses;
        }
      

        public void Add(Course coourse)
        {
            Console.WriteLine("Course Added");
        }

        public void Update()
        {
            Console.WriteLine("Course Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Course Deleted");
        }

        public void Remove()
        {
            Console.WriteLine("Course Removed");
        }
    }
}
