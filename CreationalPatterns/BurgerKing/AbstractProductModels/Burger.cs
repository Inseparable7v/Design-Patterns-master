using BurgerKing.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKing.AbstractProductModels
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Burger
    {
        public List<Ingridients> Ingridients { get; }
        public Burger()
        {
            this.Ingridients = new List<Ingridients>();
            CreateBurger();
        }

        public abstract void CreateBurger();
    }
}
