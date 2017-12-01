using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLevelAttributes
{
    class Example
    {
        [UsefulMethodMessage(s: "Some pertinent information about the method")]
        public void Foo()
        {
            Console.WriteLine("Calling Foo");
        }
      
    }
}
