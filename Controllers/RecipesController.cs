using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoRecipes.Models;

namespace ContosoRecipes.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RecipesController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetRecipes([FromQuery] int limit)
    {
      Recipe[] recipes =
      {
        new() { Title = "Oxtail" },
        new() { Title = "Curry Chiken" },
        new() { Title = "Dumplings" }
      };

      if (!recipes.Any()) return NotFound();

      return Ok(recipes.Take(limit));
    }

    [HttpPost]
    public ActionResult CreateNewRecipe([FromBody] Recipe newRecipe)
    {
      // validate and save to database
      bool badThingsHappened = false;

      if (badThingsHappened) return BadRequest();

      return Created("", newRecipe);
    }

    [HttpDelete("all")]
    public ActionResult DeleteRecipe()
    {
      bool badThingsHappened = false;

      if (badThingsHappened) return BadRequest();

      return NoContent();
    }
  }
}
