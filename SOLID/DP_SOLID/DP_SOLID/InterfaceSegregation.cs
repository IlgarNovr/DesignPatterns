using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SOLID
{
    class InterfaceSegregation
    {
        public abstract class Tree
        {
            public abstract void MinWaterInYear();
            public abstract bool HasFruit();
        }

        public abstract class GardenTree : Tree
        {
            public abstract void MaintenanceTime();
        }


        class Olive: GardenTree
        {
            public override bool HasFruit()
            {
                return true;
            }

            public override void MaintenanceTime()
            {
                Console.WriteLine("2 week");
            }

            public override void MinWaterInYear()
            {
                Console.WriteLine("1000 l");
            }
        }

        class Sequoia : Tree
        {

            public override bool HasFruit()
            {
                return false;
            }

            public override void MinWaterInYear()
            {
                Console.WriteLine(100000l);
            }
        }
    }
}
