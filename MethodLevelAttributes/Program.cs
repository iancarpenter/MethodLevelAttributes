using System;
using System.Reflection;

namespace MethodLevelAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAttribute();
        }

        public static void GetAttribute()
        {
            
            foreach(MethodInfo mi in typeof(Example).GetMethods())
            {
                UsefulMethodMessageAttribute theAttribute = (UsefulMethodMessageAttribute)Attribute.GetCustomAttribute(mi, typeof(UsefulMethodMessageAttribute));

                if (theAttribute != null)     
                {
                   Console.WriteLine($"The attribute value is: {theAttribute.S}");
                }          
            }
            
        }

    }
}
