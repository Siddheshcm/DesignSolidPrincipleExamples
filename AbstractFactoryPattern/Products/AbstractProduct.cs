using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products
{
    // Abstract Product Interface for Cars
    interface Car
    {
        void assemble();
    }

    // Abstract Product Interface for Car Specifications
    interface CarSpecification
    {
        void display();
    }

}
