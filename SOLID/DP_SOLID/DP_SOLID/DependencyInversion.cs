using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SOLID
{
    class DependencyInversion
    {
        public abstract class Employee
        {
            public string Name { get; set; }

            public string Surname { get; set; }

            public int Staj { get; set; }
           
            public int Salary { get; set; }

            public abstract void Work();

        }

        public class Worker : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Build a house");
            }
        }

        public class Programmer : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Write a code");
            }
        }
    }
}
