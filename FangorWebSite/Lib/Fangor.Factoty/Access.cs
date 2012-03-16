using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Fangor.Factoty
{
    public class Access<T>
    {
        private static Type type;

        public static Object Invoke(String MethodName, Type[] types, params Object[] values)
        {
            Object result = null;

            type = typeof(T);

            try
            {
                MethodInfo method = type.GetMethod(MethodName, types);

                if (method != null)
                {
                    result = method.Invoke(Activator.CreateInstance(type), values);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
    }
}
