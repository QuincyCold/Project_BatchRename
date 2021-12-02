using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContract;

namespace BUS01ChangeExtension
{
    class AddSuffix : IRenamingRules
    {
        public string suffix { get; set; }

        public AddSuffix(string _suffix)
        {
            suffix = _suffix;
        }
        public string Transform(string original)
        {
            return original + " " + suffix;
        }

        public override string ToString()
        {
            return "AddSuffix" + " " + suffix;
        }
    }
}
