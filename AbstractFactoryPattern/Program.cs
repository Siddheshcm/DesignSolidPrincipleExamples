using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating cars for North America
            ICarFactory northAmericaFactory = new NorthAmericaCarFactory();
            Car northAmericaCar = northAmericaFactory.createCar();
            CarSpecification northAmericaSpec = northAmericaFactory.createSpecification();

            northAmericaCar.assemble();
            northAmericaSpec.display();

            // Creating cars for Europe
            ICarFactory europeFactory = new EuropeCarFactory();
            Car europeCar = europeFactory.createCar();
            CarSpecification europeSpec = europeFactory.createSpecification();

            europeCar.assemble();
            europeSpec.display();
        }
    }
}