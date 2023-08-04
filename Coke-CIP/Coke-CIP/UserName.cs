using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coke_CIP
{
    internal class UserName
    {
        static string _UserName = "";
        public static string Name
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
    }
}
