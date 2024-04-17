using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Objects
{
    internal class SUVVehicle : Vehicle
    {
        public SUVVehicle() : base(new SportsDriveStrategy())
        {
        }
    }
}
