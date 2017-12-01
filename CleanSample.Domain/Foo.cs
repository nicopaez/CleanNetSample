using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSample.Domain
{

    public class Foo : IFoo
    {
        public string DoFoo()
        {
            return "Foo";
        }
    }
}
