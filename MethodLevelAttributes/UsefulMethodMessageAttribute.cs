using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLevelAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    class UsefulMethodMessageAttribute : Attribute
    {
        string s;

        public string S
        {
            get
            {
                return s;
            }
        }

        public UsefulMethodMessageAttribute(string s)
        {
            this.s = s;
        }


    }
}
