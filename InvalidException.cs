using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16
{
   public  class InvalidException : Exception
    {
        public InvalidException(string msg) : base(msg)
        {

        }

       
    }
}
