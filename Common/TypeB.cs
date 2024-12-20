using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA obj = new TypeA();
            //obj.x = 1;// not Valid
            obj.y = 1;// Valid
            obj.z = 2;// Valid
        }
    }
}
namespace test
{

}
