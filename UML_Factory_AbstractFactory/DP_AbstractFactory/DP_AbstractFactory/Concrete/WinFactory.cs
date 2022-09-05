using DP_AbstractFactory.Abstracts;

namespace DP_AbstractFactory.Concrete
{
    class WinFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
 
        public ICheckbox CreateCheckBox()
        {
            return new WinCheckbox();
        }
        public WinFactory() { }
    }
}
