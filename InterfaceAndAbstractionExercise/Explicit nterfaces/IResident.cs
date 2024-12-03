using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_nterfaces
{
    public interface IResident 
    {

        string GetName();
         string Name { get;  }
         string  Country { get;  }

    }
}
