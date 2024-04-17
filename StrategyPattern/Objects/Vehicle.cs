using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Objects
{
    internal class Vehicle
    {

        IDriveStrategy driveObject;
        public Vehicle(IDriveStrategy driveObj)
        {
            this.driveObject = driveObj;
        }
        public void drive()
        {
            driveObject.drive();
        }
    }
}
