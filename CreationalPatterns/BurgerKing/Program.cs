using BurgerKing.AbstractProductModels;
using System;

namespace BurgerKing
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgers = new Burger[]
            {
                new VeganBurger(),
                new WhopperBurger(),
            };

            foreach (var burger in burgers)
            {
                var burgerType = burger.GetType().Name;
                Console.WriteLine(burgerType);
                for (int i = 0; i < burger.Ingridients.Count; i++)
                {
                    var burgerIngridientsType = burger.Ingridients[i].GetType().Name;
                    Console.WriteLine(burgerIngridientsType);
                }
            }
        }
    }
}
