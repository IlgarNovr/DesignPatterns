using DP_AbstractFactory.Abstracts;
using System;

namespace DP_AbstractFactory.Concrete
{
    class MacCheckbox : ICheckbox
    {
        public void Create()
        {
            Console.WriteLine("Create Checkbox");
        }
    }
}
