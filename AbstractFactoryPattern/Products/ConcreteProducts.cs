using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products
{
    // Concrete Product for Sedan Car
    class Sedan : Car
    {

        public void assemble()
        {
            Console.WriteLine("Assembling Sedan car.");
        }
    }

    // Concrete Product for Hatchback Car
    class Hatchback : Car
    {

        public void assemble()
        {
            Console.WriteLine("Assembling Hatchback car.");
        }
    }

    // Concrete Product for North America Car Specification
    class NorthAmericaSpecification : CarSpecification
    {

        public void display()
        {
            Console.WriteLine("North America Car Specification: Safety features compliant with local regulations.");
        }
    }

    // Concrete Product for Europe Car Specification
    class EuropeSpecification : CarSpecification
    {

        public void display()
        {
            Console.WriteLine("Europe Car Specification: Fuel efficiency and emissions compliant with EU standards.");
        }
    }

}
