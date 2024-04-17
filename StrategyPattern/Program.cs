

using StrategyPattern.Objects;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             When multiple child classes are using same feature/function implementation then to avoid the duplicate code
             we use this strategy pattern in which Interface is created with common feature/function and used by implementing 
             constructor injection.
             */

            Vehicle objvehicle = new SUVVehicle();

            objvehicle.drive();

        }
    }
}