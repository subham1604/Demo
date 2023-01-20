using System.Runtime.InteropServices;

namespace OnlineRecipe.Models
{
    public interface IRepository
    {
        List<Category> GetCategories();

        List<Recipe> GetRecipeById(int cid);

    }
}
