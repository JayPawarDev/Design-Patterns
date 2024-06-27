using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public interface IButton
    {
        void Click();
    }
    public interface ITextBox
    {
        void ShowText();
    }
}
