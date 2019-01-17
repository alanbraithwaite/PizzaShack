using System.Collections.Generic;
using PizzaShack.Models;

namespace PizzaShack.Mock
{

  public static class FakeDb
  {

    public static List<string> MyValues = new List<string>() { "value1", "value2", "value3", "value4" };


    public static Dictionary<string, Topping> AvailToppings = new Dictionary<string, Topping>()
    {
      {"pepperoni", new Topping("Pepperoni", .50m)},
      {"ham", new Topping("Ham", .50m)},
      {"peppers", new Topping("Peppers", .50m)},
      {"olive", new Topping("Olives", .50m)},
      {"pineapple", new Topping("Pineapple", .50m)},
      {"cheese", new Topping("Cheese", .50m)},
      {"saug", new Topping("Sausage", .50m)},
      {"beef", new Topping("Beef", .50m)}
    };

    public static List<Pizza> Pizzas = new List<Pizza>()
    {
  new Pizza(){
   Name ="Hawaiian", Toppings = new List<Topping>()
   {
     AvailToppings.GetValueOrDefault("ham"),
     AvailToppings.GetValueOrDefault("pineapple"),
     AvailToppings.GetValueOrDefault("cheese")
   }
},
   new Pizza(){
   Name ="MeatLover", Toppings = new List<Topping>()
   {
    AvailToppings.GetValueOrDefault("ham"),
    AvailToppings.GetValueOrDefault("pep"),
    AvailToppings.GetValueOrDefault("saug"),
    AvailToppings.GetValueOrDefault("beef"),
    AvailToppings.GetValueOrDefault("cheese")
   }
},
    new Pizza(){
      Name ="Pepperoni", Toppings = new List<Topping>()
      {
        AvailToppings.GetValueOrDefault("pep"),
        AvailToppings.GetValueOrDefault("cheese")
      }
    }

    };


    public static List<Order> Orders = new List<Order>()
    {
      new Order()
    {
      Pizzas = new List<Pizza>(){
        new Pizza(){
          Toppings = new List<Topping>(){
          AvailToppings.GetValueOrDefault("pep")
          }
        },
        Pizzas.Find(p => p.Name =="MeatLover")
       }
      }
    };
  }
}