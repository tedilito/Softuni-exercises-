using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_nterfaces
{
    public interface IPerson 
    {
         string Name { get;  }
         int Age { get;  }
        string GetName();
    }
}
