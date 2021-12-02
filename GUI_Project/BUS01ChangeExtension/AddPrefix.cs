using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContract;

namespace BUS01ChangeExtension
{
    class AddPrefix : IRenamingRules
    {
        public string prefix { get; set; }

        public AddPrefix(string _prefix)
        {
            prefix = _prefix;
        }
        public string Transform(string original)
        {
            return prefix + " " + original;
        }

        public override string ToString()
        {
            return "AddPrefix" + " " + prefix;
        }
    }
}
