using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNew
{
    
    internal class AttributeCustom:Attribute
    {
        private readonly string positionalString;
      
        public AttributeCustom(string positionalString)
        {
            this.positionalString = positionalString;
            
        }

        public string PositionalString
        {
            get { return positionalString; }
        }



        
        
         
    }
}
