using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IContract
{
    public interface IDao
    {
        string Description { get; }

        BindingList<string> LoadAll1();
        List<string> LoadAll2();

        bool Insert1(string a);
        bool Insert2(IRenamingRules r);
    }
}