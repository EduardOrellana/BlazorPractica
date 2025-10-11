using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorTutorialYoutube.Data;
using BlazorTutorialYoutube.Model;

namespace BlazorTutorialYoutube.Controllers;

[Route("ingredients")]
[ApiController]
public class IngredientsController : ControllerBase
{
    private readonly RecipeContext _db;

    public IngredientsController(RecipeContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Ingredient>>> GetIngredients()
    {
        return (await _db.Ingredients.ToListAsync());
    }

    // [HttpPost]
    // public async Task<ActionResult<Recipe>> AddRecipe(Recipe recipe)
    // {
    //     _db.Recipes.Add(recipe);
    //     await _db.SaveChangesAsync();
    //     return recipe;
    // }
}
