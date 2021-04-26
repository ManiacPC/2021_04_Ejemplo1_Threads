using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Threads.Helpers
{
    public static class ExtensionMethods
    {
        public static int ToSeconds(this int original, int convertionRate = 1000)
        {
            return original * convertionRate;
        }
    }
}
