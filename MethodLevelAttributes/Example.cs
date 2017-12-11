using System;

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
