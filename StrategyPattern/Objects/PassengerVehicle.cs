using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Objects
{
    internal class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}
