using DP_AbstractFactory.Abstracts;
using System;

namespace DP_AbstractFactory.Concrete
{
    class Application
    {
        private IGUIFactory _factory;

        private IButton _button;

        private ICheckbox _checkBox;

        public Application(IGUIFactory f)
        {
            _factory = f;
        }

        public void CreateGUI()
        {
            Console.WriteLine("Create GUI");
            _button = _factory.CreateButton();
            _checkBox = _factory.CreateCheckBox();
        }

        public void Paint()
        {
            CreateGUI();
            _button.Create();
            _checkBox.Create();
        }
    }
}