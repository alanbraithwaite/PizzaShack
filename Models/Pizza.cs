using System.Collections.Generic;
using System.Linq;

namespace PizzaShack.Models
{

  public enum PizzaSizes
  {
    Personal = 1,

    Medium = 2,

    Large = 3,

    Family = 4
  }


  public class Pizza
  {

    public string Name { get; set; }
    private decimal _BasePrice = 6;
    public List<Topping> Toppings { get; set; } = new List<Topping>();
    public PizzaSizes Size { get; set; }

    public decimal Price
    {
      get
      {
        return _BasePrice + (decimal)Size + Toppings.Sum(topping => topping.Price);
      }
    }

  }


}