using Microsoft.AspNetCore.Mvc;
using model.Models;
using System.Collections.Generic;

namespace model.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentInfo()
        {
            var student = new Student();
            student.Id = 1;
            student.Name = "TUng";
            student.Age = 20;
            student.Grade = 9.9;
            student.Image = "https://media.istockphoto.com/photos/wild-grass-in-the-mountains-at-sunset-picture-id1322277517?k=20&m=1322277517&s=612x612&w=0&h=ZdxT3aGDGLsOAn3mILBS6FD7ARonKRHe_EKKa-V-Hws=";
            return View(student);
        }
        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Abc",
                    Age = 20,
                    Grade = 10
                },
                new Student
                {
                    Id = 2,
                    Name = "a",
                    Age = 19,
                    Grade = 9.9
                }
            };
            
            return View(students);
        }
        public IActionResult Razor()
        {
            return View();
        }
    }
}
