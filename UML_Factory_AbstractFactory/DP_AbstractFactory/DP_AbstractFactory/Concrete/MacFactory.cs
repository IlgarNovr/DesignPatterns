using DP_AbstractFactory.Abstracts;

namespace DP_AbstractFactory.Concrete
{
    class MacFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
        public MacFactory() { }
    }
}
