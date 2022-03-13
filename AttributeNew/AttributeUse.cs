using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNew
{
    internal class AttributeUse
    {
        [AttributeCustom("PrintAttr")]
        public void Print()
        {
            Console.WriteLine("Print method");
        }

        [AttributeCustom("NumAttr")]
        private void  Num()
        {
            Console.WriteLine("NUM Method");
        }

        public void Str(string str)
        {
            Console.WriteLine("STR Method");
        }
        
        
    }
}
