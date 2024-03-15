using Book.Web.Data;
using Book.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Book.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            
            return View();
        }
    }
}
