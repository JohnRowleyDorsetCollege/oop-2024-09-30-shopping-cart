// See https://aka.ms/new-console-template for more information
using oop_2024_09_30_shopping_cart.models;

Console.WriteLine("Hello, World!");

List<Fruit> fruits = new List<Fruit>()
{

    new Apple(), 
    new Orange()
};

Cart cart = new Cart();
    cart.AddFruit(fruits);
Console.WriteLine($"Total cost is {cart.TotalCost()/100}");