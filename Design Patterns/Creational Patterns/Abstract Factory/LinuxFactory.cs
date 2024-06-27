using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class LinuxFactory : IOperatingSystemFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LinuxTextBox();
        }
    }
}
