using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        AppDbContext context = new AppDbContext();
        public ViewResult Index()
        {
            var category = context.Categories.ToList();
            return View("Index", category);
        }

        public ViewResult Details(int Id)
        {
            var user = context.Categories.Find(Id);
            return View("details", user);
        }

        public ViewResult CreateCategory(int Id)
        {
            return View("CreateCategory");
        }

        public IActionResult Add(Category requst)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(requst);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CreateCategory", requst);
        }

        public IActionResult Delete(int id)
        {

            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateView(int id)
        {
            var category = context.Categories.Find(id);
            return View("Update", category);
        }
        public IActionResult Update(Category requst)
        {
            var category = context.Categories.Find(requst.Id);
            if (ModelState.IsValid)
            {
                context.Categories.Remove(category);
                context.Categories.Add(requst);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Update", category);
            
        }
    }
}
