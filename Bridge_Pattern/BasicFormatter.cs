using Bridge_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class BasicFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return String.Format("{0}: {1}", key, value);
        }
    }
}
