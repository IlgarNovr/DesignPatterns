using DP_AbstractFactory.Abstracts;
using System;

namespace DP_AbstractFactory.Concrete
{
    class WinCheckbox : ICheckbox
    {
        public void Create()
        {
            Console.WriteLine("Create WinCheckbox");
        }
    }
}