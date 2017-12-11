using System;

namespace MethodLevelAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class UsefulMethodMessageAttribute : Attribute
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
