using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Helpers
{
    public  static class Helper
    {
        public static string Capitalize(this string name)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;

            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
    }
    
       
}
