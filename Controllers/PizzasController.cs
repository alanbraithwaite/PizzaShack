using System.Collections.Generic;
using PizzaShack.Mock;
using PizzaShack.Models;
using Microsoft.AspNetCore.Mvc;

namespace PizzaShack.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class PizzasController : ControllerBase
  {

    [HttpGet]
    public ActionResult<IEnumerable<Pizza>> Get()
    {
      return FakeDb.Pizzas;
    }

  }



}