using System.Collections.Generic;
using PizzaShack.Mock;
using PizzaShack.Models;
using Microsoft.AspNetCore.Mvc;

namespace PizzaShack.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class ToppingsController : ControllerBase
  {

    [HttpGet]

    public ActionResult<Dictionary<string, Topping>> GetAction()
    {
      return FakeDb.AvailToppings;
    }

  }


}