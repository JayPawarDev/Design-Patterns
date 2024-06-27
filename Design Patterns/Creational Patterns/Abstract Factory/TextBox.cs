using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class WindowsTextBox : ITextBox
    {
        public void ShowText()
        {
            Console.WriteLine("Showing a Windows Text Box");
        }
    }

    public class MacTextBox : ITextBox
    {
        public void ShowText()
        {
            Console.WriteLine("Showing a Mac Text Box");
        }
    }

    public class LinuxTextBox : ITextBox
    {
        public void ShowText()
        {
            Console.WriteLine("Showing a Linux Text Box");
        }
    }
}
