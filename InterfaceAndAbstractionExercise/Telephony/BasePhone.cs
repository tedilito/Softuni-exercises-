using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public abstract class BasePhone : ICaller
    {
        protected BasePhone()
        {
            
        }

        public string Number { get;  }

        public abstract void Call(string number);

        public abstract bool IsCorrectNum(string number);
      



    }
}
