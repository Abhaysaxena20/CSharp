using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
using WebApplication3.Models;
using WebApplication3.Models.VM;

namespace WebApplication3.Controllers
{
    public class PersonalController : Controller
    {
        private ApplicationContext _context;
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment { get; set; }

        public PersonalController(ApplicationContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this._context = context;
            this.Environment = environment;
        }
        public IActionResult Index()
        {
                                                                                                                                            return View();
        }
        public IActionResult Home(int id)
        {
            var Category = _context.Categories.ToList();
            var Products = _context.Products.Where(e => e.categoryId== id).ToList();
            MergeModel mrg = new MergeModel();
            mrg.products = Products;
            mrg.category = Category;
            return View(mrg);
        }
        public IActionResult About()
        { 
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Category(CategoryVM category)
        {
            if (ModelState.IsValid)
            {
                string path = UploadFile(category.Image);
                Category cat = new Category()
                {
                   Name= category.Name,
                   Description= category.Description,
                   Image=path
                };
                _context.Categories.Add(cat);
                _context.SaveChanges();
                return View();
            }
            else
            {
                return View(category);
            }
        }
        public string UploadFile(IFormFile file)
        {
            string base_path = Environment.WebRootPath;
            var ext = Path.GetExtension(file.FileName);
            string unique_name = Guid.NewGuid().ToString() + ext;
            string filepath = Path.Combine("Images", unique_name);
            string fpath = Path.Combine(base_path, filepath);
            FileStream stream = new FileStream(fpath, FileMode.CreateNew);
            file.CopyTo(stream);

            return filepath;
        }
        public IActionResult Products()
        { 
            var Products = _context.Products.Include(e=>e.category).ToList();
            return View(Products);
        }
        [HttpPost]
        public IActionResult Products(CategoryVM category)
        {
            ViewBag.cat = _context.Categories.ToList();
            if (ModelState.IsValid)
            {
                string path = UploadFile(category.Image);
                Products prod = new Products()
                {
                    Name = category.Name,
                    Description = category.Description,
                    categoryId=category.Id,
                    Image = path
                };
                _context.Products.Add(prod);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            else
            {
                return View();
            }
        }
        public IActionResult AddProduct()
        {
            ViewBag.Category = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string name)
        {
            ViewBag.Category = _context.Categories.ToList();
            string Name = Request.Form["Name"].ToString();
            string Description = Request.Form["Description"].ToString();
            string Category = Request.Form["Category"].ToString();
            IFormFile Image = null;
            if (Request.Form.Files.Count > 0)
            {
                Image = Request.Form.Files[0];
            }
            var cat = _context.Categories.SingleOrDefault(c => c.Id==Convert.ToInt32(Category));
            Products prod = new Products()
            {
                Name = Name,
                Description = Description,
                category = cat,
                Image = UploadFile(Image)

            };
            _context.Products.Add(prod);
            _context.SaveChanges();
            return RedirectToAction("Products");
        }
        public IActionResult DeleteProduct(int id)
        {
            ViewBag.Category= _context.Categories.FirstOrDefault(c => c.Id==id);
            var prod = _context.Products.SingleOrDefault(e => e.Id == id);
            if (prod == null)
                return View("Error");
            else
            {
                _context.Products.Remove(prod);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
        }
        public IActionResult EditProduct(int id)
        {
            ViewBag.category = _context.Categories.ToList();
            var prod = _context.Products.Include(e => e.category).SingleOrDefault(e => e.Id == id);
            if (prod == null)
                return View("Error");
            else
            {
                ProductVM products = new ProductVM()
                {
                    Id = prod.Id,
                    Name = prod.Name,
                    Description = prod.Description,
                    Category = prod.category.Id,
                    Image = prod.Image
                };
                return View(products);
            }

        }
        [HttpPost]
        public IActionResult EditProduct(ProductVM products)
        {
            ViewBag.category = _context.Categories.ToList();
            var prod = _context.Products.SingleOrDefault(e => e.Id == products.Id);
            string file_path = string.Empty;
            if (Request.Form.Files.Count > 0)
            {
                var image = Request.Form.Files[0];
                file_path = UploadFile(image);
            }
            if (prod != null)
            {
                prod.Name = products.Name;
                prod.Description = products.Description;
                prod.category = _context.Categories.SingleOrDefault(e => e.Id == products.Category);
                prod.Image = file_path == string.Empty ? prod.Image : file_path;
                _context.Products.Update(prod);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View(products);

        }
        public IActionResult Employee(int id)
        {
           // var prod = _context.Employees.SingleOrDefault(e => e.Id == id);
            return View();
        }
        [HttpPost]
        public IActionResult Employee(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Gender = employee.Gender,
                    Address = employee.Address,
                    Phone = employee.Phone,
                    Pincode = employee.Pincode,
                    Password = employee.Password
                };
                if (employee.Skills.Count > 0)
                {
                    emp.Skills = "";
                    foreach (var skill in employee.Skills)
                    {
                        emp.Skills += (skill + ",");
                    }
                }
                else
                {
                    ModelState.AddModelError("Skills", "Select atleast one skill");
                    return View(employee);
                }
                    _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("Employee");
            }
            else
            {
                return View();
            }
        }
    }

    }
