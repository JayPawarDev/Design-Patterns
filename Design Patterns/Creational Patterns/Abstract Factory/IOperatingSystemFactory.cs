using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public interface IOperatingSystemFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
