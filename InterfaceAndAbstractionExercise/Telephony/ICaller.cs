using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public interface ICaller
    {
        string Number { get; }
        void Call(string number);

    

    }
}
