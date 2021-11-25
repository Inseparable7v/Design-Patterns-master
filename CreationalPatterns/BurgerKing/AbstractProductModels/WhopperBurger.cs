using BurgerKing.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKing.AbstractProductModels
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class WhopperBurger : Burger
    {
        public override void CreateBurger()
        {
            base.Ingridients.Add(new Beef());
            base.Ingridients.Add(new Cheese());
            base.Ingridients.Add(new Lettuce());
            base.Ingridients.Add(new Tomato());
            base.Ingridients.Add(new Onion());
        }
    }
}
