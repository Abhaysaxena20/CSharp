using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        private readonly ApplicationContext _context;
        public AjaxController(ApplicationContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    var email = HttpContext.Session.GetString("UserEmail");

        //    if (string.IsNullOrEmpty(email))
        //    {
        //        return RedirectToAction("Login");
        //    }

        //    var data = _context.UserEmployees.ToList();
        //    return View(data);
        //};
       
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserEmail")))
            {
                return View("Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = _context.UserEmployees
                        .FirstOrDefault(x => x.Email == model.Email);
            if (user == null || user.Password != model.Password)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View(model);
            }
            HttpContext.Session.SetString("UserEmail", user.Email);
            HttpContext.Session.SetString("UserRole", user.Role);
            HttpContext.Session.SetInt32("UserId", user.Id);
            return RedirectToAction("Index", "Ajax");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public JsonResult UserEmployees()
        {
            var data = _context.UserEmployees.ToList();
            return new JsonResult(data);
        }
        //public JsonResult AddEmployee([FromBody] UserEmployees employees)
        //{

        //    _context.UserEmployees.Add(employees);
        //    _context.SaveChanges();
        //    return new JsonResult("Data is saved");
        //}

        [HttpPost]
        public JsonResult UserEmployees([FromBody] MergeModel mergeModel)
        {
            var emp = new UserEmployees()
            {
                Name = mergeModel.Name,
                Email = mergeModel.Email,
                Password = mergeModel.Password,
                Salary = mergeModel.Salary,
                Role = mergeModel.Role,
            };

            _context.UserEmployees.Add(emp);
            _context.SaveChanges();
            return new JsonResult("Data is saved");
        }
        [HttpGet]
        public JsonResult Edit(int id)
        {
            var data = _context.UserEmployees.Where(e => e.Id == id).FirstOrDefault();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Update([FromBody] UserEmployees userEmployees)
        {
            var emp = _context.UserEmployees.Find(userEmployees.Id);
            if (emp == null)
            {
                return new JsonResult("Data not found");
            }
            emp.Name = userEmployees.Name;
            emp.Email = userEmployees.Email;
            emp.Password = userEmployees.Password;
            emp.Salary = userEmployees.Salary;
            emp.Role = userEmployees.Role;

            _context.UserEmployees.Update(emp);
            _context.SaveChanges();
            return new JsonResult("Record Updated");
            //_context.UserEmployees.Update(userEmployees);
            //_context.SaveChanges();
            //return new JsonResult("Data Updated");
        }
        [HttpGet]
        public JsonResult Delete(int id)
        {
            var data = _context.UserEmployees.Where(e => e.Id == id).SingleOrDefault();
            _context.UserEmployees.Remove(data);
            _context.SaveChanges();
            return new JsonResult("Data deleted");
        }

    }
}
