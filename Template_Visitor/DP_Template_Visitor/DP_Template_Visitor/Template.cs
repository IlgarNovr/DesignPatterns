using System;

namespace DP_Template_Visitor
{
    class Template
    {


        public abstract class House
        {
            public void BuildHouse()
            {
                BuildFoundation();
                BuildWalls();
                BuildWindows();

                Console.WriteLine("House is built");
            }

            public abstract void BuildFoundation();

            public abstract void BuildWindows();

            public abstract void BuildWalls();

        }

        public class WoodHouse : House
        {
            public override void BuildFoundation()
            {
                Console.WriteLine("Building Foundations with wood");
            }

            public override void BuildWalls()
            {
                Console.WriteLine("Building walls with wood");
            }

            public override void BuildWindows()
            {
                Console.WriteLine("Building windows with wood");
            }
        }

        public class ConcreteHouse : House
        {
            public override void BuildFoundation()
            {
                Console.WriteLine("Building Foundations with concrete");
            }

            public override void BuildWalls()
            {
                Console.WriteLine("Building walls with concrete");
            }

            public override void BuildWindows()
            {
                Console.WriteLine("Building windows with concrete");
            }
        }
    }
}