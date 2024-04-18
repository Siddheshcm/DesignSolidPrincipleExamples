using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    // Concrete Factory for North America Cars
    class NorthAmericaCarFactory : ICarFactory
    {

        public Car createCar()
        {
            return new Sedan();
        }

        public CarSpecification createSpecification()
        {
            return new NorthAmericaSpecification();
        }
    }

    // Concrete Factory for Europe Cars
    class EuropeCarFactory : ICarFactory
    {

        public Car createCar()
        {
            return new Hatchback();
        }

        public CarSpecification createSpecification()
        {
            return new EuropeSpecification();
        }
    }

}
