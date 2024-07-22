using Microsoft.AspNetCore.Mvc;
using ProjectEcommerce.Data;
using ProjectEcommerce.Models;

namespace ProjectEcommerce.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<CategoryModel> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
