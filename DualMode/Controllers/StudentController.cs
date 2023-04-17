using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DualModel.Models;

namespace DualModel.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details ";

            Student s1 = new Student()
            {
                StudentId = 100, 
                StudentName = "XYZ",
                Branch = "CSE"
            };
            Address A1 = new Address()
            {
                StudentId = 100,
                City = "Mysore",
                State = "Karnataka",
                Country = "India"
            };
            StudentDetailsViewModel s2 = new StudentDetailsViewModel
            {
                Student = s1,
                Address = A1,
                Title = "Student Details",
                Header = "Student Details Page"
            };
            return View(s2);
        }
    }
}
