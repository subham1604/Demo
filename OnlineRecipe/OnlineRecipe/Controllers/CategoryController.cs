using Microsoft.AspNetCore.Mvc;
using OnlineRecipe.Models;

namespace OnlineRecipe.Controllers
{
    public class CategoryController : Controller
    {
       private Repository repository;

        public CategoryController()
        {
            repository = new Repository();
            
        }
        public IActionResult Index()
        {
            var lstCat = repository.GetCategories();
            return View(lstCat);
        }

        public IActionResult RecipeList(int cid)
        {
            var lstRec = repository.GetRecipeById(cid);
            return View(lstRec);
        }


    }
}
