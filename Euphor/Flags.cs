using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphor
{
    /// <summary>
    /// For events.
    /// </summary>
    class Flags
    {
        private static Dictionary<string, bool> flags = new Dictionary<string,bool>();

        public static bool GetFlag(string flagName)
        {
            try
            {
                return flags[flagName];
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        //The next two methods will add/remove a flag state, 
        //by setting the GetFlag method to true/false.
        public static void SetFlag(string flagName)
        {
            flags[flagName] = true;
        }
        
        public static void UnSetflag(string flagName)
        {
            flags[flagName] = false;
        }
    }
}
