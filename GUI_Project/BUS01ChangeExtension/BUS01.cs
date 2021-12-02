using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IContract;
using System.ComponentModel;

namespace BUS01ChangeExtension
{
    public class BUS01ChangeExtension : IBus
    {

        public string Description => "Bus01 - Basic renaming rule";

        public IDao Dao { get; set; }

        public bool Insert1(string a)
        {
            Dao.Insert1(a);
            return true;
        }

        public bool Insert2(IRenamingRules r)
        {
            Dao.Insert2(r);
            return true;
        }

        public BindingList<string> LoadAll1()
        {
            return Dao.LoadAll1();
        }

        public BindingList<IRenamingRules> LoadAll2()
        {
            BindingList<IRenamingRules> listRulesResult = new BindingList<IRenamingRules>();

            List<string> listTemp = Dao.LoadAll2();
            foreach(string stringSingleRule in listTemp)
            {
                IRenamingRules temp = null;
                var Token = stringSingleRule.Split(new string[] { " " }, StringSplitOptions.None);
                switch(Token[0])
                {
                    case "RenamingExtension":
                        temp = new RenamingExtension(Token[1]);
                        break;

                    case "AddPrefix":
                        temp = new AddPrefix(Token[1]);
                        break;

                    case "AddSuffix":
                        temp = new AddSuffix(Token[1]);
                        break;
                }

                listRulesResult.Add(temp);
            }

            return listRulesResult;
        }
    }
}