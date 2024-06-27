using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Pressing a Windows Button");
        }
    }

    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Pressing a Mac Button");
        }
    }

    public class LinuxButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Pressing a Linux Button");
        }
    }
}
