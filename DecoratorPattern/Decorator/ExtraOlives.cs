using DecoratorPattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class ExtraOlives : ToppingDecorator
    {
        BasePizza objBasePizza;
        public ExtraOlives(BasePizza pizza)
        {
            this.objBasePizza = pizza;
        }
        public override int cost()
        {
            return this.objBasePizza.cost() + 15;
        }
    }
}
