using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    internal interface ICarFactory
    {
        Car createCar();
        CarSpecification createSpecification();
    }
}
