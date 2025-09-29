using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        AppDbContext context = new AppDbContext();
        public ViewResult ShowCategories()
        {
            var users = context.categories.ToList();
            return View("Index", users);
        }

        public ViewResult Details (int Id)
        {
            var user = context.categories.Find(Id);
            return View("details", user);
        }
    }
}
