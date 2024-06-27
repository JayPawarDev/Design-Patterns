
namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            IOperatingSystemFactory osFactory = UIFactory.CreateFactory(OSType.Windows);
            IButton button = osFactory.CreateButton();
            ITextBox textBox = osFactory.CreateTextBox();

            button.Click();
            textBox.ShowText();

        }
    }
}
