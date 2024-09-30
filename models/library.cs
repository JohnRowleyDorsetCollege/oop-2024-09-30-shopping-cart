using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_09_30_shopping_cart.models
{
    public static class CONSTANTS {

        public const double COST_APPLE = .60;
        public const double COST_ORANGE = .25;
    }
    public abstract class Fruit
    {
        public string Name { get; set; }
        public double cost { get; set; }
    }
    public class Apple : Fruit
    {
        public Apple() { cost = CONSTANTS.COST_APPLE; }
    }

    public class Orange : Fruit
    {
        public Orange() { cost = CONSTANTS.COST_ORANGE; }
    }

    public class Cart
    {
        public List<Fruit> fruits { get; set; } = new();

        public void AddFruit(List<Fruit> _listOfFruit)
        {
            fruits.AddRange(_listOfFruit);
        }

        public double TotalCost()
        {
            double totalCost = 0;
            foreach (var fruit in fruits)
            {
                totalCost += fruit.cost;

            }
            return totalCost;
        }

    }
}
