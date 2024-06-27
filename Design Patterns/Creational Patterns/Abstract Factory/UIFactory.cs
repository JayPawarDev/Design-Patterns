using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory
{
    public class UIFactory
    {
        public static IOperatingSystemFactory CreateFactory(OSType os)
        {
            switch (os)
            {
                case OSType.Windows:
                    return new WindowsFactory();

                case OSType.Mac:
                    return new MacFactory();    

                case OSType.Linux:
                    return new LinuxFactory();

                default:
                    throw new NotSupportedException($"{os} is not supported");
            }
        }
    }
}
