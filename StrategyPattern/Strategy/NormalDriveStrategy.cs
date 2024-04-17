using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal class NormalDriveStrategy : IDriveStrategy
    {
        public void drive()
        {
            Console.Write("Normal drive Started");
        }
    }
}
