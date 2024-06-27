using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype
{
    public class Registry
    {
        private Dictionary<string, Vehicle> _registry;

        public Registry()
        {
            _registry = new Dictionary<string, Vehicle>();
        }

        public Vehicle GetClone(string key)
        {
            return _registry[key].Clone();
        }

        public void Register(string key, Vehicle value)
        {
            this._registry.Add(key, value);
        }
    }
}
