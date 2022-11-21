using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    internal class Reflection
    {
        private class Key
        {
            internal Type Type { get; set; }
            internal string Name { get; set; }

        }
        private readonly ConcurrentDictionary<Key, Func<object, object>> propertyGetters;
        public Reflection()
        {
            propertyGetters = new ConcurrentDictionary<Key, Func<object, object>>();
        }
    }
}
