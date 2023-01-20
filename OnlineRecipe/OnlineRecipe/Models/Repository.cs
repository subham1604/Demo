using CategoryAdoLib;

namespace OnlineRecipe.Models
{
    public class Repository : IRepository
    {
       
        public List<Category> GetCategories()
        {
            AdoConnected dal = new AdoConnected();

            return dal.GetCategories().Select(o=> new Category
            {
                categoryId = o.categoryId,
                categoryName = o.categoryName,
            }).ToList();
            
        }


        public List<Recipe> GetRecipeById(int cid)
        {
            AdoConnected dal = new AdoConnected();
            

            return dal.GetRecipesById(cid).Select(o => new Recipe
            {
                categoryId = o.categoryId,
                recipeName = o.recipeName,
                picture = o.picture,
                description=o.description,
            }).ToList();
           
        }
    }
}
