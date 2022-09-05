using DP_AbstractFactory.Abstracts;
using System;

namespace DP_AbstractFactory.Concrete
{
    class WinButton : IButton
    {
        public void Create()
        {
            Console.WriteLine("Create WinButton");
        }
    }
}
