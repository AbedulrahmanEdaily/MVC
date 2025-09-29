using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        AppDbContext context = new AppDbContext();
        
      public ViewResult GetAllData()
        {
            var users = context.categories.ToList();
            return View("Index", users);
        }

        public ViewResult CreateUser()
        {
            return View("CreateUser");
        }
    }
}
