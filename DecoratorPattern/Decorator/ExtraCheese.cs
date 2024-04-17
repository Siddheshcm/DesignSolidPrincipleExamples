using DecoratorPattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class ExtraCheese : ToppingDecorator
    {
        BasePizza objBasePizza;
        public ExtraCheese(BasePizza pizza)
        {
            this.objBasePizza = pizza;                
        }
        public override int cost()
        {
            return this.objBasePizza.cost() + 10;
        }
    }
}
