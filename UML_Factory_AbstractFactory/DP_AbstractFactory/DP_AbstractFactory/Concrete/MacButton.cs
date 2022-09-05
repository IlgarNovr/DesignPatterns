using DP_AbstractFactory.Abstracts;
using System;

namespace DP_AbstractFactory.Concrete
{
    class MacButton : IButton
    {
        public void Create()
        {
            Console.WriteLine("Create MacButton");
        }
    }
}