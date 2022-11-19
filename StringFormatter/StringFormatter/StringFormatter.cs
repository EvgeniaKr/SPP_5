using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    public class StringFormatter : IStringFormatter
    {
        public static readonly StringFormatter Shared = new StringFormatter();

        public StringFormatter()
        {
        }

        public string Format(string template, object target)
        {
            throw new NotImplementedException();
        }
    }
}
