using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    [AttributeUsage(AttributeTargets.Struct,AllowMultiple =true,Inherited =true)]
    public class KeyAttribute:Attribute
    {

    }
}
