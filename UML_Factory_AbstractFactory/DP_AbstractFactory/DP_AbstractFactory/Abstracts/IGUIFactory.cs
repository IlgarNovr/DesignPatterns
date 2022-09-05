namespace DP_AbstractFactory.Abstracts
{
    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}
