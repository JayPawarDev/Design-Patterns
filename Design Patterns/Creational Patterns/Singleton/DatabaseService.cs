using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Singleton
{
    sealed class DatabaseService
    {
        private DatabaseService() { }

        private static DatabaseService _instance;

        private static readonly object _instanceLock = new object();
        private static int _instanceCount = 0;
        public static DatabaseService GetInstance(string threadName)
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseService();
                        _instanceCount++;
                    }
                }
            }
            Console.WriteLine($"For Thread {threadName} the instance count is {_instanceCount}");
            return _instance;
        }
    }
}
